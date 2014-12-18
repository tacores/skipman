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
        private FormOwner formOwner;

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

    }
}
