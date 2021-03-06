﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMusicTagger
{
    public enum Tags
    {
        Genre,
        Performers,
        Album,
        Title,
        AlbumArtists
    }
    public class TagDiff
    {
        public string FilePath { get; set; }
        public Tags Tag { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: {1} -> {2}", Tag.ToString(), OldValue ?? "<NULL>", NewValue ?? "<NULL>");
        }
    }
    public class TagDiffs : List<TagDiff>
    {
        public OrderedDiffs GetOrderedDiffs()
        {
            var ordered = new OrderedDiffs();
            foreach (var diff in this)
            {
                if (!ordered.ContainsKey(diff.FilePath))
                    ordered.Add(diff.FilePath, new TagDiffs());
                ordered[diff.FilePath].Add(diff);
            }
            return ordered;
        }
    }
    public class OrderedDiffs : Dictionary<string, TagDiffs>
    {
    }
}
