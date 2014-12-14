using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// 音楽ファイルタグクラスのTagLib#実装
    /// </summary>
    class MusicTagLibImpl : MusicTag
    {
        public MusicTagLibImpl(string filePath)
        {
            tagFile = TagLib.File.Create(filePath);
        }

        public void Dispose()
        {
            tagFile.Dispose();
        }

        public string AlbumTitle
        {
            get { return tagFile.Tag.Album; }
            set { tagFile.Tag.Album = value;  }
        }

        public uint Disc
        {
            get { return tagFile.Tag.Disc; }
            set { tagFile.Tag.Disc = value; }
        }
        public uint DiscCount
        {
            get { return tagFile.Tag.DiscCount; }
            set { tagFile.Tag.DiscCount = value; }
        }

        public uint Track
        {
            get { return tagFile.Tag.Track; }
            set { tagFile.Tag.Track = value; }
        }
        public uint TrackCount
        {
            get { return tagFile.Tag.TrackCount; }
            set { tagFile.Tag.TrackCount = value; }
        }

        public string Title
        {
            get { return tagFile.Tag.Title; }
            set { tagFile.Tag.Title = value;  }
        }

        public string FilePath
        {
            get;
            set;
        }

        public string Artist
        {
            get
            {
                try
                {
                    return tagFile.Tag.FirstPerformer;
                }
                catch (Exception)
                {
                    return "";
                }
            }
            set {}
        }

        public void save()
        {
            tagFile.Save();
        }

        private TagLib.File tagFile;
    }
}
