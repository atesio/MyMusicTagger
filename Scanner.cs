using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMusicTagger
{
    public static class Scanner
    {
        public static bool IsSupported(string fileName)
        {
            var ext = System.IO.Path.GetExtension(fileName).ToUpper();
            switch (ext)
            {
                case ".MP3":
                case ".FLAC":
                    return true;
                default:
                    return false;
            }
        }

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
                if (!IsSupported(fileName))
                    continue;
                var filePath = System.IO.Path.Combine(folderPath, fileName);
                files.Add(filePath);
            }
        }
        public static void GetDiffs(List<string> filePaths, System.ComponentModel.BackgroundWorker worker, out TagDiffs diffs, out FileErrors errors)
        {
            diffs = new TagDiffs();
            errors = new FileErrors();
            int index = 0;
            int total = filePaths.Count();
            foreach (var filePath in filePaths)
            {
                if (worker.CancellationPending) return;
                index += 1;
                worker.ReportProgress(index*100/total, filePath);
                AddDiffs(diffs, errors, filePath);
            }
        }

        private static void AddDiffs(TagDiffs diffs, FileErrors errors, string filePath)
        {
            TagLib.File file;
            try
            {
                file = TagLib.File.Create(filePath);
            }
            catch (TagLib.CorruptFileException ex)
            {
                errors.Add(new FileError { FilePath = filePath, Message = ex.Message });
                return;
            }
            var current = new Dictionary<Tags, string>();
            var expected = new Dictionary<Tags, string>();
            var folderPath = System.IO.Path.GetDirectoryName(filePath);
            var parts = folderPath.Split('\\');
            expected.Add(Tags.Album, parts[parts.Length - 1]);
            expected.Add(Tags.Performers, parts[parts.Length - 2]);
            expected.Add(Tags.AlbumArtists, parts[parts.Length - 2]);
            expected.Add(Tags.Genre, parts[parts.Length - 3]);
            current.Add(Tags.Album, file.Tag.Album);
            current.Add(Tags.Performers, String.Join(";", file.Tag.Performers));
            current.Add(Tags.AlbumArtists, String.Join(";", file.Tag.AlbumArtists));
            current.Add(Tags.Genre, String.Join(";", file.Tag.Genres));
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
        public static void WriteDiffs(OrderedDiffs diffs, System.ComponentModel.BackgroundWorker worker, out FileErrors errors)
        {
            errors = new FileErrors();
            int total = diffs.Count();
            int index = 0;
            foreach (var filePath in diffs.Keys)
            {
                if (worker.CancellationPending) return;
                index += 1;
                worker.ReportProgress(index * 100 / total, filePath);
                try
                {
                    WriteDiff(filePath, diffs[filePath]);
                }
                catch (Exception ex)
                {
                    errors.Add(new FileError { FilePath = filePath, Message = ex.Message });
                }
            }
        }

        private static void WriteDiff(string filePath, TagDiffs diffs)
        {
            var file = TagLib.File.Create(filePath);
            foreach (var diff in diffs)
            {
                switch (diff.Tag)
                {
                    case Tags.Genre:
                        file.Tag.Genres = new string[] { diff.NewValue };
                        break;
                    case Tags.Performers:
                        file.Tag.Performers = new string[] { diff.NewValue };
                        break;
                    case Tags.Album:
                     //   if (diff.NewValue != null && diff.NewValue.Length > 30) diff.NewValue = diff.NewValue.Substring(0, 30);
                        file.Tag.Album = diff.NewValue;
                        break;
                    case Tags.Title:
                        file.Tag.Title = diff.NewValue;
                        break;
                    case Tags.AlbumArtists:
                        file.Tag.AlbumArtists = new string[] { diff.NewValue };
                        break;
                }
            }
            file.Save();
        }
    }
}
