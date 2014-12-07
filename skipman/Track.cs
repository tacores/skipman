using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class Track
    {
        public Track(uint track, string name, string path)
        {
            this.track = track;
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

        public uint track
        {
            get;
            set;
        }
    }
}
