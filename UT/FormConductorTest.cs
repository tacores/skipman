using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT
{
    using NUnit.Framework;
    using skipman;
    using skipmanUT.stub;

    [TestFixture]
    public class FormConductorTest
    {
        private FormConductor sut;
        private StateProviderStub stateProvider;
        private FormOwnerStub formOwner;

        [SetUp]
        public void Init()
        {
            stateProvider = new StateProviderStub();
            formOwner = new FormOwnerStub();
            sut = new FormConductor(stateProvider, formOwner);
        }

        [Test]
        public void InitialState_ScanButtonDisabled()
        {
            sut.update();

            Assert.AreEqual(false, formOwner.ScanButtonEnabled);
        }

        [Test]
        public void InitialState_SelectedAlbumButtonDisabled()
        {
            sut.update();

            Assert.AreEqual(false, formOwner.SelectedAlbumButtonEnabled);
        }

        [Test]
        public void InitialState_AllAlbumButtonDisabled()
        {
            sut.update();

            Assert.AreEqual(false, formOwner.AllAlbumButtonEnabled);
        }

        [Test]
        public void AfterMusicFolderSet_ScanButtonEnabled()
        {
            stateProvider.IsMusicFolderSet = true;

            sut.update();

            Assert.AreEqual(true, formOwner.ScanButtonEnabled);
        }

        [Test]
        public void IfScanIsRunning_ScanButtonDisabled()
        {
            stateProvider.IsMusicFolderSet = true;
            stateProvider.IsScanning = true;

            sut.update();

            Assert.AreEqual(false, formOwner.ScanButtonEnabled);
        }

        [Test]
        public void MusicFolderMecomesNotSet_ScanButtonDisabled()
        {
            //実際には起こらないケース
            stateProvider.IsMusicFolderSet = true;
            sut.update();

            stateProvider.IsMusicFolderSet = false;
            sut.update();

            Assert.AreEqual(false, formOwner.ScanButtonEnabled);
        }

        [Test]
        public void AlbumIsSelected_SelectedAlbumButtonEnabled()
        {
            stateProvider.IsAnyAlbumSelected = true;

            sut.update();

            Assert.AreEqual(true, formOwner.SelectedAlbumButtonEnabled);
        }

        [Test]
        public void IfScanIsRunning_SelectedAlbumButtonDisabled()
        {
            stateProvider.IsAnyAlbumSelected = true;
            stateProvider.IsScanning = true;

            sut.update();

            Assert.AreEqual(false, formOwner.SelectedAlbumButtonEnabled);
        }

        [Test]
        public void BecomesNotSelected_SelectedAlbumButtonDisabled()
        {
            stateProvider.IsAnyAlbumSelected = true;
            sut.update();

            stateProvider.IsAnyAlbumSelected = false;
            sut.update();

            Assert.AreEqual(false, formOwner.SelectedAlbumButtonEnabled);
        }
        
        [Test]
        public void ThereIsAnyAlbums_AllAlbumButtonEnabled()
        {
            stateProvider.IsThrereAnyAlbumNeedToReset = true;

            sut.update();

            Assert.AreEqual(true, formOwner.AllAlbumButtonEnabled);
        }

        [Test]
        public void IfScanIsRunning_AllAlbumButtonDisabled()
        {
            stateProvider.IsThrereAnyAlbumNeedToReset = true;
            stateProvider.IsScanning = true;

            sut.update();

            Assert.AreEqual(false, formOwner.AllAlbumButtonEnabled);
        }

        [Test]
        public void BecomesThereIsNoAlbum_AllAlbumButtonDisabled()
        {
            stateProvider.IsThrereAnyAlbumNeedToReset = true;
            sut.update();

            stateProvider.IsThrereAnyAlbumNeedToReset = false;
            sut.update();

            Assert.AreEqual(false, formOwner.AllAlbumButtonEnabled);
        }

        [Test]
        public void AlbumIsSelected_RemoveButtonEnabled()
        {
            stateProvider.IsAnyAlbumSelected = true;

            sut.update();

            Assert.AreEqual(true, formOwner.RemoveButtonEnabled);
        }

        [Test]
        public void IfScanIsRunning_RemoveButtonDisabled()
        {
            stateProvider.IsAnyAlbumSelected = true;
            stateProvider.IsScanning = true;

            sut.update();

            Assert.AreEqual(false, formOwner.RemoveButtonEnabled);
        }

        [Test]
        public void BecomesNotSelected_RemoveButtonDisabled()
        {
            stateProvider.IsAnyAlbumSelected = true;
            sut.update();

            stateProvider.IsAnyAlbumSelected = false;
            sut.update();

            Assert.AreEqual(false, formOwner.RemoveButtonEnabled);
        }
    }
}
