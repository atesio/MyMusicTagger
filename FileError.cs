using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicTagger
{
    public struct FileError
    {
        public string FilePath { get; set; }
        public string Message { get; set; }
    }

    public class FileErrors : List<FileError>
    {
    }
}
