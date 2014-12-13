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
    public class AlbumDictionaryCreatorTest
    {
        private AlbumDictionaryCreatorImpl sut;
        private MusicTagStub stub;

        [SetUp]
        public void Init()
        {
            sut = new AlbumDictionaryCreatorImpl();
            stub = new MusicTagStub();
            MusicTagFactory.set(stub);
        }

        [Test]
        public void FileIsNotExist_ReturnEmptyDictionary()
        {
            //setup
            string[] files = new string[0];
 
            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(0, dict.Count);
        }

        [Test]
        public void OneFileExists_ReturnOneAlbum()
        {
            //setup
            string path1 = "path1";
            string[] files = new string[1];
            files[0] = path1;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 1;
            MusicTagStub.pathDiscCountDictionary[path1] = 1;
            MusicTagStub.pathTrackDictionary[path1] = 1;
            MusicTagStub.pathTrackCountDictionary[path1] = 1;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(1, dict.Count);
        }

        [Test]
        public void TwoFiles_DifferentAlbum_ReturnTwoAlbum()
        {
            //setup
            string path1 = "path1";
            string path2 = "path2";
            string[] files = new string[2];
            files[0] = path1;
            files[1] = path2;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 1;
            MusicTagStub.pathDiscCountDictionary[path1] = 1;
            MusicTagStub.pathTrackDictionary[path1] = 1;
            MusicTagStub.pathTrackCountDictionary[path1] = 1;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            MusicTagStub.pathAlbumDictionary[path2] = "album2";
            MusicTagStub.pathDiscDictionary[path2] = 1;
            MusicTagStub.pathDiscCountDictionary[path2] = 1;
            MusicTagStub.pathTrackDictionary[path2] = 1;
            MusicTagStub.pathTrackCountDictionary[path2] = 1;
            MusicTagStub.pathTitleDictionary[path2] = "title2";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(2, dict.Count);
        }

        [Test]
        public void TwoFiles_SameAlbum_ReturnOneAlbum()
        {
            //setup
            string path1 = "path1";
            string path2 = "path2";
            string[] files = new string[2];
            files[0] = path1;
            files[1] = path2;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 1;
            MusicTagStub.pathDiscCountDictionary[path1] = 1;
            MusicTagStub.pathTrackDictionary[path1] = 1;
            MusicTagStub.pathTrackCountDictionary[path1] = 2;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            MusicTagStub.pathAlbumDictionary[path2] = "album1";
            MusicTagStub.pathDiscDictionary[path2] = 1;
            MusicTagStub.pathDiscCountDictionary[path2] = 1;
            MusicTagStub.pathTrackDictionary[path2] = 2;
            MusicTagStub.pathTrackCountDictionary[path2] = 2;
            MusicTagStub.pathTitleDictionary[path2] = "title2";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(1, dict.Count);
        }

        [Test]
        public void DiscIs0_ShouldNotAddAlbum()
        {
            //setup
            string path1 = "path1";
            string[] files = new string[1];
            files[0] = path1;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 0;
            MusicTagStub.pathDiscCountDictionary[path1] = 1;
            MusicTagStub.pathTrackDictionary[path1] = 1;
            MusicTagStub.pathTrackCountDictionary[path1] = 1;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(0, dict.Count);
        }

        [Test]
        public void DiscCountIs0_ShouldNotAddAlbum()
        {
            //setup
            string path1 = "path1";
            string[] files = new string[1];
            files[0] = path1;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 1;
            MusicTagStub.pathDiscCountDictionary[path1] = 0;
            MusicTagStub.pathTrackDictionary[path1] = 1;
            MusicTagStub.pathTrackCountDictionary[path1] = 1;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(0, dict.Count);
        }

        [Test]
        public void TrackIs0_ShouldNotAddAlbum()
        {
            //setup
            string path1 = "path1";
            string[] files = new string[1];
            files[0] = path1;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 1;
            MusicTagStub.pathDiscCountDictionary[path1] = 1;
            MusicTagStub.pathTrackDictionary[path1] = 0;
            MusicTagStub.pathTrackCountDictionary[path1] = 1;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(0, dict.Count);
        }

        [Test]
        public void TrackCountIs0_ShouldNotAddAlbum()
        {
            //setup
            string path1 = "path1";
            string[] files = new string[1];
            files[0] = path1;

            MusicTagStub.pathAlbumDictionary[path1] = "album1";
            MusicTagStub.pathDiscDictionary[path1] = 1;
            MusicTagStub.pathDiscCountDictionary[path1] = 1;
            MusicTagStub.pathTrackDictionary[path1] = 1;
            MusicTagStub.pathTrackCountDictionary[path1] = 0;
            MusicTagStub.pathTitleDictionary[path1] = "title1";

            //exercise
            Dictionary<string, Album> dict = sut.create(files);

            //verify
            Assert.AreEqual(0, dict.Count);
        }

    }
}
