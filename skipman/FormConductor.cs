using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class FormConductor
    {
        private StateProvider provider;
        private FormOwner owner;

        public FormConductor(StateProvider provider, FormOwner owner)
        {
            this.provider = provider;
            this.owner = owner;
        }

        public void update()
        {
            updateScanButton();
            updateSelectedButton();
            updateAllButton();
        }

        private void updateScanButton()
        {
            if (provider.IsMusicFolderSet && !provider.IsScanning)
            {
                owner.ScanButtonEnabled = true;
            }
            else
            {
                owner.ScanButtonEnabled = false;
            }
        }

        private void updateSelectedButton()
        {
            if (provider.IsAnyAlbumSelected && !provider.IsScanning)
            {
                owner.SelectedAlbumButtonEnabled = true;
            }
            else
            {
                owner.SelectedAlbumButtonEnabled = false;
            }
        }

        private void updateAllButton()
        {
            if (provider.IsThrereAnyAlbumNeedToReset && !provider.IsScanning)
            {
                owner.AllAlbumButtunEnabled = true;
            }
            else
            {
                owner.AllAlbumButtunEnabled = false;
            }
        }
    }
}
