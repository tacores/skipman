using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public interface FormOwner
    {
        bool ScanButtonEnabled
        {
            set;
        }

        bool SelectedAlbumButtonEnabled
        {
            set;
        }

        bool AllAlbumButtunEnabled
        {
            set;
        }
    }
}
