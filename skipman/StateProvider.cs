using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public interface StateProvider
    {
        bool IsMusicFolderSet
        {
            get;
        }

        bool IsScanning
        {
            get;
        }

        bool IsAnyAlbumSelected
        {
            get;
        }

        bool IsThrereAnyAlbumNeedToReset
        {
            get;
        }
    }
}
