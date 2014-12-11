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
            pathTrackDictionary = new Dictionary<string, uint>();
        }

        public void Dispose()
        {
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

        public string path
        {
            get;
            set;
        }

        public void save()
        {
            pathTrackDictionary[path] = track;
        }

        static public Dictionary<string, uint> pathTrackDictionary;
    }
}
