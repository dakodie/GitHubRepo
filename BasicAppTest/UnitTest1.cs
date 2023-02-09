using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_Basic_App_GitHub;

namespace BasicAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 tp = new Class1();
            Assert.AreEqual(tp.Name, "[Dakota Strawn] - The Code Master");
        }
    }
}