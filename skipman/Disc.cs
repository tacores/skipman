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
            TrackCount = trackCount;
            tracks = new Track[trackCount];
            DiskNum = disk;
        }

        public void addTrack(uint track, string name, string path, string artist)
        {
            tracks[track - 1] = new Track(track, name, path, artist);
        }

        public Track getTrack(uint track)
        {
            return tracks[track - 1];
        }

        public uint TrackCount
        {
            get;
            set;
        }

        public uint DiskNum
        {
            get;
            set;
        }

        Track[] tracks;
    }
}
