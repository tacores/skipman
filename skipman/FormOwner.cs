﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public interface FormOwner
    {
        bool ScanButtonEnabled
        {
            get;
            set;
        }

        bool SelectedAlbumButtonEnabled
        {
            get;
            set;
        }

        bool AllAlbumButtunEnabled
        {
            get;
            set;
        }
    }
}
