using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class Album
    {
        public Album(string title, uint discCount)
        {
            this.Title = title;
            this.DiscCount = discCount;
            discs = new Disc[discCount];
            dict = new Dictionary<uint, string>();
            AllTrackCount = 0;
            needCorrect = false;
        }

        public void addTrack(uint disc, uint track, uint trackCount, string name, string path, string artist)
        {
            if (discs[disc - 1] == null)
            {
                discs[disc - 1] = new Disc(disc, trackCount);
            }
            discs[disc - 1].addTrack(track, name, path, artist);
            AllTrackCount++;

            if (dict.ContainsKey(track))
            {
                needCorrect = true;
            }
            else
            {
                dict[track] = "";
            }
        }

        public string Title
        {
            get;
            set;
        }
        public uint DiscCount
        {
            get;
            set;
        }
        public uint AllTrackCount
        {
            get;
            set;
        }

        private Dictionary<uint, string> dict;
        public bool needCorrect
        {
            get;
            set;
        }

        public Disc getDisc(uint disc)
        {
            return discs[disc - 1];
        }

        Disc[] discs;
    }
}
