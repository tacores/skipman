using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT.stub
{
    using skipman;

    class FormOwnerStub : FormOwner
    {
        public bool ScanButtonEnabled
        {
            get;
            set;
        }

        public bool SelectedAlbumButtonEnabled
        {
            get;
            set;
        }

        public bool AllAlbumButtunEnabled
        {
            get;
            set;
        }
    }
}
