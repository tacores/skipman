using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class Track
    {
        public Track(uint track, string name, string path, string artist)
        {
            TrackNum = track;
            Name = name;
            Path = path;
            Artist = artist;
        }

        public string Path
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public uint TrackNum
        {
            get;
            set;
        }

        public string Artist
        {
            get;
            set;
        }
    }
}
