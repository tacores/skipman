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

            Assert.AreEqual(3, sut.DiskNum);
        }

        [Test]
        public void Constructor_TrackCount()
        {
            Disc sut = new Disc(AnonDisc, 20);

            Assert.AreEqual(20, sut.TrackCount);
        }

        [Test]
        public void AddTrack_CreateExpectedTrack()
        {
            Disc sut = new Disc(AnonDisc, 20);

            sut.addTrack(10, "name", "path", "artist");

            Track expect = new Track(10, "name", "path", "artist");
            Track ret = sut.getTrack(10);
            Assert.AreEqual(expect.TrackNum, ret.TrackNum);
            Assert.AreEqual(expect.Title, ret.Title);
            Assert.AreEqual(expect.FilePath, ret.FilePath);
            Assert.AreEqual(expect.Artist, ret.Artist);
        }

        [Test]
        public void AddTrack_CreateExpectedTrack_LowerBound()
        {
            Disc sut = new Disc(AnonDisc, 20);

            sut.addTrack(1, "name", "path", "artist");

            Track expect = new Track(1, "name", "path", "artist");
            Track ret = sut.getTrack(1);
            Assert.AreEqual(expect.TrackNum, ret.TrackNum);
            Assert.AreEqual(expect.Title, ret.Title);
            Assert.AreEqual(expect.FilePath, ret.FilePath);
            Assert.AreEqual(expect.Artist, ret.Artist);
        }

        [Test]
        public void AddTrack_CreateExpectedTrack_UpperBound()
        {
            Disc sut = new Disc(AnonDisc, 20);

            sut.addTrack(20, "name", "path", "artist");

            Track expect = new Track(20, "name", "path", "artist");
            Track ret = sut.getTrack(20);
            Assert.AreEqual(expect.TrackNum, ret.TrackNum);
            Assert.AreEqual(expect.Title, ret.Title);
            Assert.AreEqual(expect.FilePath, ret.FilePath);
            Assert.AreEqual(expect.Artist, ret.Artist);
        }

        [Test]
        public void AddTrack_OutofLowerBounds_ThrowIndexOutOfRange()
        {
            Disc sut = new Disc(AnonDisc, 20);

            try
            {
                sut.addTrack(0, "name", "path", "artist");
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            Assert.Fail("IndexOutOfRangeException was not thrown.");
        }

        [Test]
        public void AddTrack_OutofUpperBounds_ThrowIndexOutOfRange()
        {
            Disc sut = new Disc(AnonDisc, 20);

            try
            {
                sut.addTrack(21, "name", "path", "artist");
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            Assert.Fail("IndexOutOfRangeException was not thrown.");
        }

        private const uint AnonDisc = 1;
        private const uint TrackCount = 10;
    }
}
