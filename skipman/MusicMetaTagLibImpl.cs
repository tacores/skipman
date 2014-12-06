using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    class MusicMetaTagLibImpl : MusicTag
    {
        public MusicMetaTagLibImpl(string filePath)
        {
            tagFile = TagLib.File.Create(filePath);
        }

        public void Dispose()
        {
            tagFile.Dispose();
        }

        public string album
        {
            get;
            set;
        }

        public uint disk
        {
            get;
            set;
        }
        public uint diskCount
        {
            get;
            set;
        }

        public uint track
        {
            get;
            set;
        }
        public uint trackCount
        {
            get;
            set;
        }

        private TagLib.File tagFile;
    }
}
