using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT.stub
{
    using skipman;

    class StateProviderStub : StateProvider
    {
        public bool IsMusicFolderSet
        {
            get;
            set;
        }

        public bool IsScanning
        {
            get;
            set;
        }

        public bool IsAnyAlbumSelected
        {
            get;
            set;
        }

        public bool IsThrereAnyAlbumNeedToReset
        {
            get;
            set;
        }
    }
}
