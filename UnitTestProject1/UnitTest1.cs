using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using ClassLibrary2;



namespace ClassLibrary2.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void GeefLeeftijdTest()
        {
            Persoon p = new Persoon();

            p.GeboorteDatum = new DateTime(1990, 07, 08);
            Assert.AreEqual(24, p.GeefLeeftijd());
        }
    }
}

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTelOp()
        {
            int result = Program.TelOp(2, 3);
            Assert.AreEqual(result, 5);
           
        }
    }
}
