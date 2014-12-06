using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    interface MusicTag : IDisposable
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
    }
}
