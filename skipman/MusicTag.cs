using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public interface MusicTag : IDisposable
    {
        string album
        {
            get;
            set;
        }

        uint disc
        {
            get;
            set;
        }
        uint discCount
        {
            get;
            set;
        }

        uint track
        {
            get;
            set;
        }
        uint trackCount
        {
            get;
            set;
        }

        string title
        {
            get;
            set;
        }

        string path
        {
            get;
            set;
        }

        string artist
        {
            get;
            set;
        }

        void save();
    }
}
