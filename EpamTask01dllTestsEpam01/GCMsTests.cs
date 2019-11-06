using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamTask01dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask01dll.TestsEpam01
{
    [TestClass()]
    public class GCMsTests
    {
        [TestMethod()]
        public void GCMTest()
        {
            int a = 130;
            int b = 105;
            int result = GCMs.GCM(a, b);
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void GCMTest1()
        {
            int a = 117;
            int b = 19;
            int c = 3;
            int result = GCMs.GCM(a, b, c);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void BinaryGCMTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GCMTimeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BinaryGCMTimeTest()
        {
            Assert.Fail();
        }
    }
}