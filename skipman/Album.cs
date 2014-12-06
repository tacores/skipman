using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    class Album
    {
        public Album(string title, uint discCount)
        {
            this.title = title;
            this.discCount = discCount;
            discs = new Disc[discCount];
            dict = new Dictionary<uint, string>();
            allTrackCount = 0;
            needHosei = false;
        }

        public void addTrack(uint disk, uint track, uint trackCount, string name, string path)
        {
            if (discs[disk - 1] == null)
            {
                discs[disk - 1] = new Disc(disk, trackCount);
            }
            discs[disk - 1].addTrack(track, name, path);
            allTrackCount++;

            if (dict.ContainsKey(track))
            {
                needHosei = true;
            }
            else
            {
                dict[track] = "";
            }
        }

        public string title
        {
            get;
            set;
        }
        public uint discCount
        {
            get;
            set;
        }
        public uint allTrackCount
        {
            get;
            set;
        }
        private Dictionary<uint, string> dict;
        public bool needHosei
        {
            get;
            set;
        }

        public Disc getDisc(uint index)
        {
            return discs[index];
        }

        Disc[] discs;
    }
}
