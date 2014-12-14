using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT.stub
{
    using skipman;

    class MusicTagStub : MusicTag
    {
        public MusicTagStub()
        {
            pathAlbumDictionary = new Dictionary<string, string>();
            pathDiscDictionary = new Dictionary<string, uint>();
            pathDiscCountDictionary = new Dictionary<string, uint>();
            pathTrackDictionary = new Dictionary<string, uint>();
            pathTrackCountDictionary = new Dictionary<string, uint>();
            pathTitleDictionary = new Dictionary<string, string>();
        }

        public void Dispose()
        {
        }

        public string AlbumTitle
        {
            get { return pathAlbumDictionary[FilePath]; }
            set { pathAlbumDictionary[FilePath] = value;  }
        }

        public uint Disc
        {
            get { return pathDiscDictionary[FilePath]; }
            set { pathDiscDictionary[FilePath] = value; }
        }
        public uint DiscCount
        {
            get { return pathDiscCountDictionary[FilePath]; }
            set { pathDiscCountDictionary[FilePath] = value; }
        }

        public uint Track
        {
            get { return pathTrackDictionary[FilePath]; }
            set { pathTrackDictionary[FilePath] = value; }
        }
        public uint TrackCount
        {
            get { return pathTrackCountDictionary[FilePath]; }
            set { pathTrackCountDictionary[FilePath] = value; }
        }

        public string Title
        {
            get { return pathTitleDictionary[FilePath]; }
            set { pathTitleDictionary[FilePath] = value; }
        }

        public string FilePath
        {
            get;
            set;
        }

        public string Artist
        {
            get;
            set;
        }

        public void save()
        {
            pathTrackDictionary[FilePath] = Track;
        }

        static public Dictionary<string, string> pathAlbumDictionary;
        static public Dictionary<string, uint> pathDiscDictionary;
        static public Dictionary<string, uint> pathDiscCountDictionary;
        static public Dictionary<string, uint> pathTrackDictionary;
        static public Dictionary<string, uint> pathTrackCountDictionary;
        static public Dictionary<string, string> pathTitleDictionary;
    }
}
