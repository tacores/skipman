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
    public class TrackResetterTest
    {
        private TrackResetter sut;
        private MusicTagStub stub;

        [SetUp]
        public void Init()
        {
            sut = new TrackResetter();
            stub = new MusicTagStub();
            MusicTagFactory.FTO_set(stub);
        }

        [Test]
        public void TwoDiscs_EachHaveTwoTracks()
        {
            Album album = new Album("title", 2);
            album.addTrack(1, 1, 2, "", "1-1", "");
            album.addTrack(1, 2, 2, "", "1-2", "");
            album.addTrack(2, 1, 2, "", "2-1", "");
            album.addTrack(2, 2, 2, "", "2-2", "");

            sut.reset(album);

            Assert.AreEqual(1, MusicTagStub.pathTrackDictionary["1-1"]);
            Assert.AreEqual(2, MusicTagStub.pathTrackDictionary["1-2"]);
            Assert.AreEqual(3, MusicTagStub.pathTrackDictionary["2-1"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackDictionary["2-2"]);
        }

        [Test]
        public void TwoDiscs_EachHaveTwoTracks_2()
        {
            Album album = new Album("title", 2);
            album.addTrack(1, 1, 2, "", "1-1", "");
            album.addTrack(1, 2, 2, "", "1-2", "");
            album.addTrack(2, 2, 3, "", "2-2", "");
            album.addTrack(2, 3, 3, "", "2-3", "");

            sut.reset(album);

            Assert.AreEqual(1, MusicTagStub.pathTrackDictionary["1-1"]);
            Assert.AreEqual(2, MusicTagStub.pathTrackDictionary["1-2"]);
            Assert.AreEqual(3, MusicTagStub.pathTrackDictionary["2-2"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackDictionary["2-3"]);
        }

        [Test]
        public void TwoDiscs_EachHaveTwoTracks_3()
        {
            Album album = new Album("title", 2);
            album.addTrack(1, 1, 2, "", "1-1", "");
            album.addTrack(1, 2, 2, "", "1-2", "");
            album.addTrack(2, 3, 4, "", "2-3", "");
            album.addTrack(2, 4, 4, "", "2-4", "");

            sut.reset(album);

            Assert.AreEqual(1, MusicTagStub.pathTrackDictionary["1-1"]);
            Assert.AreEqual(2, MusicTagStub.pathTrackDictionary["1-2"]);
            Assert.AreEqual(3, MusicTagStub.pathTrackDictionary["2-3"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackDictionary["2-4"]);
        }

        [Test]
        public void TwoDiscs_EachHaveTwoTracks_4()
        {
            Album album = new Album("title", 2);
            album.addTrack(1, 1, 2, "", "1-1", "");
            album.addTrack(1, 2, 2, "", "1-2", "");
            album.addTrack(2, 4, 5, "", "2-4", "");
            album.addTrack(2, 5, 5, "", "2-5", "");

            sut.reset(album);

            Assert.AreEqual(1, MusicTagStub.pathTrackDictionary["1-1"]);
            Assert.AreEqual(2, MusicTagStub.pathTrackDictionary["1-2"]);
            Assert.AreEqual(3, MusicTagStub.pathTrackDictionary["2-4"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackDictionary["2-5"]);
        }

        [Test]
        public void OneDisc_SplitTracks()
        {
            Album album = new Album("title", 1);
            album.addTrack(1, 1, 10, "", "1-1", "");
            album.addTrack(1, 10, 10, "", "1-10", "");

            sut.reset(album);

            Assert.AreEqual(1, MusicTagStub.pathTrackDictionary["1-1"]);
            Assert.AreEqual(2, MusicTagStub.pathTrackDictionary["1-10"]);
        }

        [Test]
        public void TrackCount_SetAllCount()
        {
            Album album = new Album("title", 2);
            album.addTrack(1, 1, 2, "", "1-1", "");
            album.addTrack(1, 2, 2, "", "1-2", "");
            album.addTrack(2, 1, 2, "", "2-1", "");
            album.addTrack(2, 2, 2, "", "2-2", "");

            sut.reset(album);

            Assert.AreEqual(4, MusicTagStub.pathTrackCountDictionary["1-1"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackCountDictionary["1-2"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackCountDictionary["2-1"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackCountDictionary["2-2"]);
        }
    }
}
