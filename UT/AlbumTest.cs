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

            Assert.AreEqual("title", sut.title);
        }

        [Test]
        public void Constructor_DiscCount()
        {
            Album sut = new Album("", 3);

            Assert.AreEqual(3, sut.discCount);
        }

    }
}
