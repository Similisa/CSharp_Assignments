using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject1_Mstest
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Trace.WriteLine("Class Initializer");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("Class Cleanup");           
        }
        [TestInitialize]
        public void BeforeTest()
        {
            Trace.WriteLine("Tests Initialized");
        }
       
        [TestCleanup]
        public void AfterTest()
        {
            Trace.WriteLine("Tests cleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("Test Method 1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("Test Method 2");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Trace.WriteLine("Test Method 3");
        }
    }
}
