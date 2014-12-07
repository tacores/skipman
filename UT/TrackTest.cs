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
            Track sut = new Track(100, "", "");

            Assert.AreEqual(100, sut.track);
        }

        [Test]
        public void Constructor_Name()
        {
            Track sut = new Track(0, "name", "");

            Assert.AreEqual("name", sut.name);
        }

        [Test]
        public void Constructor_Path()
        {
            Track sut = new Track(0, "", "path");

            Assert.AreEqual("path", sut.path);
        }

        [Test]
        public void Constructor_ChangeTrack()
        {
            Track sut = new Track(100, "", "");
            sut.track = 200;

            Assert.AreEqual(200, sut.track);
        }

        [Test]
        public void Constructor_ChangeName()
        {
            Track sut = new Track(0, "name", "");
            sut.name = "newname";

            Assert.AreEqual("newname", sut.name);
        }

        [Test]
        public void Constructor_ChangePath()
        {
            Track sut = new Track(0, "", "path");
            sut.path = "newpath";

            Assert.AreEqual("newpath", sut.path);
        }
    }
}
