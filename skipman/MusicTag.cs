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

        uint disk
        {
            get;
            set;
        }
        uint diskCount
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

        string path
        {
            get;
            set;
        }

        void save();
    }
}
