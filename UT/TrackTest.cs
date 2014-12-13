using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipmanUT
{
    using NUnit.Framework;
    using skipman;

    [TestFixture]
    public class TrackTest
    {
        [Test]
        public void Constructor_Track()
        {
            Track sut = new Track(100, "", "", "");

            Assert.AreEqual(100, sut.TrackNum);
        }

        [Test]
        public void Constructor_Name()
        {
            Track sut = new Track(0, "name", "", "");

            Assert.AreEqual("name", sut.Name);
        }

        [Test]
        public void Constructor_Path()
        {
            Track sut = new Track(0, "", "path", "");

            Assert.AreEqual("path", sut.Path);
        }

        [Test]
        public void ChangeTrack()
        {
            Track sut = new Track(100, "", "", "");
            sut.TrackNum = 200;

            Assert.AreEqual(200, sut.TrackNum);
        }

        [Test]
        public void ChangeName()
        {
            Track sut = new Track(0, "name", "", "");
            sut.Name = "newname";

            Assert.AreEqual("newname", sut.Name);
        }

        [Test]
        public void ChangePath()
        {
            Track sut = new Track(0, "", "path", "");
            sut.Path = "newpath";

            Assert.AreEqual("newpath", sut.Path);
        }

        [Test]
        public void ChangeArtist()
        {
            Track sut = new Track(0, "", "path", "");
            sut.Artist = "artist-name";

            Assert.AreEqual("artist-name", sut.Artist);
        }
    }
}
