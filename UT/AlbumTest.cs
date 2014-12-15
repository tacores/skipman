using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT
{
    using NUnit.Framework;
    using skipman;

    [TestFixture]
    public class AlbumTest
    {
        [Test]
        public void Constructor_Title()
        {
            Album sut = new Album("title", 1);

            Assert.AreEqual("title", sut.Title);
        }

        [Test]
        public void Constructor_DiscCount()
        {
            Album sut = new Album("", 3);

            Assert.AreEqual(3, sut.DiscCount);
        }

        [Test]
        public void AddTrack_DiscIsCreated()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 10, 15, "track1", "path1", "artist1");
            Disc disc = sut.getDisc(1);

            Assert.AreEqual(1, disc.DiskNum);
        }

        [Test]
        public void AddTrack_TrackIsCreated()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 10, 15, "track1", "path1", "artist1");
            Track track = sut.getDisc(1).getTrack(10);

            Assert.AreEqual(10, track.TrackNum);
            Assert.AreEqual("track1", track.Title);
            Assert.AreEqual("path1", track.FilePath);
            Assert.AreEqual("artist1", track.Artist);
        }

        [Test]
        public void AddTrack_HeadTrack()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 1, 15, "track1", "path1", "artist1");
            Track track = sut.getDisc(1).getTrack(1);

            Assert.AreEqual(1, track.TrackNum);
            Assert.AreEqual("track1", track.Title);
            Assert.AreEqual("path1", track.FilePath);
            Assert.AreEqual("artist1", track.Artist);
        }

        [Test]
        public void AddTrack_TailTrack()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 15, 15, "track1", "path1", "artist1");
            Track track = sut.getDisc(1).getTrack(15);

            Assert.AreEqual(15, track.TrackNum);
            Assert.AreEqual("track1", track.Title);
            Assert.AreEqual("path1", track.FilePath);
            Assert.AreEqual("artist1", track.Artist);
        }

        [Test]
        public void GetDisc_HeadDisc()
        {
            Album sut = new Album("", 3);

            Disc disc = sut.getDisc(1);

            Assert.IsNull(disc);
        }

        [Test]
        public void GetDisc_TailDisc()
        {
            Album sut = new Album("", 3);

            Disc disc = sut.getDisc(3);

            Assert.IsNull(disc);
        }

        [Test]
        public void GetDisc_OutOfDiscCount_ThrowIndexOutOfRange()
        {
            Album sut = new Album("", 3);

            try
            {
                sut.getDisc(4);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [Test]
        public void AddTrack_OnSameDisc_TrackIsCreatedOnSameDisc()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 10, 15, "track1", "path1", "artist1");
            sut.addTrack(1, 11, 15, "track2", "path2", "artist2");
            Track track1 = sut.getDisc(1).getTrack(10);
            Track track2 = sut.getDisc(1).getTrack(11);

            Assert.AreEqual(11, track2.TrackNum);
            Assert.AreEqual("track2", track2.Title);
            Assert.AreEqual("path2", track2.FilePath);
            Assert.AreEqual("artist2", track2.Artist);
        }

        [Test]
        public void AddTrack_OnDifferentDisc_TrackIsCreatedOnDifferentDisc()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 10, 15, "track1", "path1", "artist1");
            sut.addTrack(2, 11, 15, "track2", "path2", "artist2");
            Track track2 = sut.getDisc(2).getTrack(11);

            Assert.AreEqual(11, track2.TrackNum);
            Assert.AreEqual("track2", track2.Title);
            Assert.AreEqual("path2", track2.FilePath);
            Assert.AreEqual("artist2", track2.Artist);
        }

        [Test]
        public void AddTrack_OnDifferentDisc_DifferentTrack_NeedNotCorrect()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 10, 15, "track1", "path1", "artist1");
            sut.addTrack(2, 11, 15, "track2", "path2", "artist2");

            Assert.AreEqual(false, sut.TrackNumberCorrectIsNeeded);
        }

        [Test]
        public void AddTrack_OnDifferentDisc_SameTrack_NeedCorrect()
        {
            Album sut = new Album("", 3);

            sut.addTrack(1, 10, 15, "track1", "path1", "artist1");
            sut.addTrack(2, 10, 15, "track2", "path2", "artist2");

            Assert.AreEqual(true, sut.TrackNumberCorrectIsNeeded);
        }

    }
}
