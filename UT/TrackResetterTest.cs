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
            MusicTagFactory.set(stub);
        }

        [Test]
        public void Twodiscs_Each2Tracks()
        {
            Album album = new Album("title", 2);
            album.addTrack(1, 1, 2, "", "1-1");
            album.addTrack(1, 2, 2, "", "1-2");
            album.addTrack(2, 1, 2, "", "2-1");
            album.addTrack(2, 2, 2, "", "2-2");

            sut.reset(album);

            Assert.AreEqual(1, MusicTagStub.pathTrackDictionary["1-1"]);
            Assert.AreEqual(2, MusicTagStub.pathTrackDictionary["1-2"]);
            Assert.AreEqual(3, MusicTagStub.pathTrackDictionary["2-1"]);
            Assert.AreEqual(4, MusicTagStub.pathTrackDictionary["2-2"]);
        }

    }
}
