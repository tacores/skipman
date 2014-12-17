using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public interface StateProvider
    {
        bool isMusicFolderFound();

        bool isScanning();

        bool isAnyAlbumSelected();

        bool isThereAnyAlbum();
    }
}
