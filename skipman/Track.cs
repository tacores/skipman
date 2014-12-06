using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    class Track
    {
        public Track(uint track, string name, string path)
        {
            oldTrackNum = track;
            this.name = name;
            this.path = path;
        }

        public string path
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public uint oldTrackNum
        {
            get;
            set;
        }

        uint newTrackNum;
    }
}
