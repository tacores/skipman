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

        public string album
        {
            get { return pathAlbumDictionary[path]; }
            set { pathAlbumDictionary[path] = value;  }
        }

        public uint disc
        {
            get { return pathDiscDictionary[path]; }
            set { pathDiscDictionary[path] = value; }
        }
        public uint discCount
        {
            get { return pathDiscCountDictionary[path]; }
            set { pathDiscCountDictionary[path] = value; }
        }

        public uint track
        {
            get { return pathTrackDictionary[path]; }
            set { pathTrackDictionary[path] = value; }
        }
        public uint trackCount
        {
            get { return pathTrackCountDictionary[path]; }
            set { pathTrackCountDictionary[path] = value; }
        }

        public string title
        {
            get { return pathTitleDictionary[path]; }
            set { pathTitleDictionary[path] = value; }
        }

        public string path
        {
            get;
            set;
        }

        public void save()
        {
            pathTrackDictionary[path] = track;
        }

        static public Dictionary<string, string> pathAlbumDictionary;
        static public Dictionary<string, uint> pathDiscDictionary;
        static public Dictionary<string, uint> pathDiscCountDictionary;
        static public Dictionary<string, uint> pathTrackDictionary;
        static public Dictionary<string, uint> pathTrackCountDictionary;
        static public Dictionary<string, string> pathTitleDictionary;
    }
}
