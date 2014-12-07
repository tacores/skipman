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
            get { return tagFile.Tag.Album; }
            set { tagFile.Tag.Album = value;  }
        }

        public uint disk
        {
            get { return tagFile.Tag.Disc; }
            set { tagFile.Tag.Disc = value; }
        }
        public uint diskCount
        {
            get { return tagFile.Tag.DiscCount; }
            set { tagFile.Tag.DiscCount = value; }
        }

        public uint track
        {
            get { return tagFile.Tag.Track; }
            set { tagFile.Tag.Track = value; }
        }
        public uint trackCount
        {
            get { return tagFile.Tag.TrackCount; }
            set { tagFile.Tag.TrackCount = value; }
        }

        public void save()
        {
            tagFile.Save();
        }

        private TagLib.File tagFile;
    }
}
