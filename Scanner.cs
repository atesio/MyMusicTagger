using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMP3Tagger
{
    public static class Scanner
    {
        public static List<string> GetFiles(string folderPath)
        {
            var paths = new List<string>();
            AddFiles(paths, folderPath);
            paths.Sort();
            return paths;
        }
        private static void AddFiles(List<string> files, string folderPath)
        {
            foreach (var subFolder in System.IO.Directory.GetDirectories(folderPath))
            {
                var subFolderPath = System.IO.Path.Combine(folderPath, subFolder);
                AddFiles(files, subFolderPath);
            }
            foreach (var fileName in System.IO.Directory.GetFiles(folderPath))
            {
                if (!fileName.ToUpper().EndsWith(".MP3"))
                    continue;
                var filePath = System.IO.Path.Combine(folderPath, fileName);
                files.Add(filePath);
            }
        }
        public static TagDiffs GetDiffs(List<string> filePaths, System.ComponentModel.BackgroundWorker worker)
        {
            var diffs = new TagDiffs();
            int index = 0;
            int total = filePaths.Count();
            foreach (var filePath in filePaths)
            {
                if (worker.CancellationPending) return null;
                index += 1;
                worker.ReportProgress(index*100/total, filePath);
                AddDiffs(diffs, filePath);
            }
            return diffs;
        }
        private static void AddDiffs(TagDiffs diffs, string filePath)
        {
            var current = new Dictionary<Tags, string>();
            var expected = new Dictionary<Tags, string>();
            var id3 = new HundredMilesSoftware.UltraID3Lib.UltraID3();
            id3.Read(filePath);
            var folderPath = System.IO.Path.GetDirectoryName(filePath);
            var parts = folderPath.Split('\\');
            expected.Add(Tags.Album, parts[parts.Length - 1]);
            expected.Add(Tags.Artist, parts[parts.Length - 2]);
            expected.Add(Tags.Band, parts[parts.Length - 2]);
            expected.Add(Tags.Genre, parts[parts.Length - 3]);
            current.Add(Tags.Album, id3.ID3v2Tag.Album);
            current.Add(Tags.Artist, id3.ID3v2Tag.Artist);
            current.Add(Tags.Genre, id3.ID3v2Tag.Genre);
            string band;
            var bandFrame = id3.ID3v2Tag.Frames.GetFrame(HundredMilesSoftware.UltraID3Lib.CommonSingleInstanceID3v2FrameTypes.Band);
            band = "<None>";
            if (bandFrame != null && bandFrame.IsSet)
            {
                if (bandFrame is HundredMilesSoftware.UltraID3Lib.ID3v23BandFrame)
                {
                    var tBandFrame = (HundredMilesSoftware.UltraID3Lib.ID3v23BandFrame)bandFrame;
                    band = tBandFrame.Band;
                }
                else if (bandFrame is HundredMilesSoftware.UltraID3Lib.ID3v22BandFrame)
                {
                    var tBandFrame = (HundredMilesSoftware.UltraID3Lib.ID3v22BandFrame)bandFrame;
                    band = tBandFrame.Band;
                }
                else
                    System.Diagnostics.Debugger.Break();
            }
            current.Add(Tags.Band, band);
            foreach (var tag in expected.Keys)
            {
                if (expected[tag] != current[tag])
                {
                    var diff = new TagDiff();
                    diff.Tag = tag;
                    diff.FilePath = filePath;
                    diff.OldValue = current[tag];
                    diff.NewValue = expected[tag];
                    diffs.Add(diff);
                }
            }
        }
        public static void WriteDiffs(OrderedDiffs diffs, System.ComponentModel.BackgroundWorker worker)
        {
            int total = diffs.Count();
            int index = 0;
            foreach (var filePath in diffs.Keys)
            {
                if (worker.CancellationPending) return;
                index += 1;
                worker.ReportProgress(index * 100 / total, filePath);
                WriteDiff(filePath, diffs[filePath]);
            }
        }

        private static void WriteDiff(string filePath, TagDiffs diffs)
        {
            var id3 = new HundredMilesSoftware.UltraID3Lib.UltraID3();
            id3.Read(filePath);
            foreach (var diff in diffs)
            {
                switch (diff.Tag)
                {
                    case Tags.Genre:
                        id3.ID3v2Tag.Genre = diff.NewValue;
                        break;
                    case Tags.Artist:
                        id3.ID3v1Tag.Artist = diff.NewValue;
                        id3.ID3v2Tag.Artist = diff.NewValue;
                        break;
                    case Tags.Album:
                        if (diff.NewValue != null && diff.NewValue.Length > 30) diff.NewValue = diff.NewValue.Substring(0, 30);
                        id3.ID3v1Tag.Album = diff.NewValue;
                        id3.ID3v2Tag.Album = diff.NewValue;
                        break;
                    case Tags.Title:
                        id3.ID3v1Tag.Title = diff.NewValue;
                        id3.ID3v2Tag.Title = diff.NewValue;
                        break;
                    case Tags.Band:
                        var bandFrame = id3.ID3v2Tag.Frames.GetFrame(HundredMilesSoftware.UltraID3Lib.CommonSingleInstanceID3v2FrameTypes.Band);
                        if (bandFrame == null || !bandFrame.IsSet)
                        {
                            if (id3.ID3v2Tag.Version == HundredMilesSoftware.UltraID3Lib.ID3v2TagVersions.ID3v22)
                            {
                                var tBandFrame = new HundredMilesSoftware.UltraID3Lib.ID3v22BandFrame(diff.NewValue);
                                id3.ID3v2Tag.Frames.Add(tBandFrame);
                            }
                            else if (id3.ID3v2Tag.Version == HundredMilesSoftware.UltraID3Lib.ID3v2TagVersions.ID3v23)
                            {
                                var tBandFrame = new HundredMilesSoftware.UltraID3Lib.ID3v23BandFrame(diff.NewValue);
                                id3.ID3v2Tag.Frames.Add(tBandFrame);
                            }
                            else
                                throw new NotImplementedException("id3 band frame tag version not handled: " + id3.ID3v2Tag.Version.ToString());
                        }
                        else if (bandFrame is HundredMilesSoftware.UltraID3Lib.ID3v23BandFrame)
                        {
                            var tBandFrame = (HundredMilesSoftware.UltraID3Lib.ID3v23BandFrame)bandFrame;
                            tBandFrame.Band = diff.NewValue;
                        }
                        else if (bandFrame is HundredMilesSoftware.UltraID3Lib.ID3v22BandFrame)
                        {
                            var tBandFrame = (HundredMilesSoftware.UltraID3Lib.ID3v22BandFrame)bandFrame;
                            tBandFrame.Band = diff.NewValue;
                        }
                        else
                            throw new NotImplementedException("band frame tag version not handled: " + bandFrame.GetType().ToString());
                        break;
                }
            }
            id3.Write();
        }
    }
}
