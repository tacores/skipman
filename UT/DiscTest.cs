using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT
{
            
    using NUnit.Framework;
    using skipman;

    [TestFixture]
    public class DiscTest
    {
        [Test]
        public void Constructor_DiscNumber()
        {
            Disc sut = new Disc(3, TrackCount);

            Assert.AreEqual(3, sut.disk);
        }

        [Test]
        public void Constructor_TrackCount()
        {
            Disc sut = new Disc(AnonDisc, 20);

            Assert.AreEqual(20, sut.trackCount);
        }

        [Test]
        public void AddTrack_CreateExpectedTrack()
        {
            Disc sut = new Disc(AnonDisc, 20);

            sut.addTrack(10, "name", "path");

            Track expect = new Track(10, "name", "path");
            Track ret = sut.getTrack(10);
            Assert.AreEqual(expect.track, ret.track);
            Assert.AreEqual(expect.name, ret.name);
            Assert.AreEqual(expect.path, ret.path);
        }

        private const uint AnonDisc = 1;
        private const uint TrackCount = 10;
    }
}
