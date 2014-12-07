using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class Disc
    {
        public Disc(uint disk, uint trackCount)
        {
            this.trackCount = trackCount;
            tracks = new Track[trackCount];
            this.disk = disk;
        }

        public void addTrack(uint track, string name, string path)
        {
            tracks[track - 1] = new Track(track, name, path);
        }

        public Track getTrack(uint track)
        {
            return tracks[track - 1];
        }

        public uint trackCount
        {
            get;
            set;
        }

        public uint disk
        {
            get;
            set;
        }

        Track[] tracks;
    }
}
