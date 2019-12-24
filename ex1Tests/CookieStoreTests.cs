using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using ex1;

namespace ex1Tests
{
    [TestClass]
    public class CookieStoreTests
    {
        [TestMethod]
        public void TestCreateHelloWorldCookieForFlowSteps()
        {
            CookieStore store = new CookieStore();
            var cookie = store.CreateHelloWorldCookie();
            TestFlowSteps(cookie);
        }


        [TestMethod]
        public void TestCreateHelloWorldCookieExtForFlowSteps()
        {
            CookieStoreExt store = new CookieStoreExt();
            var cookie = store.CreateHelloWorldCookie();
            TestFlowSteps(cookie);
        }

        [TestMethod]
        public void TestCreateHelloWorldCookiePerf()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            CookieStore store = new CookieStore();
            for (int i = 0; i < 3; i++)
                store.CreateHelloWorldCookie();

            sw.Stop();
           Console.WriteLine("Time taken: " + sw.Elapsed);

        }

        private void TestFlowSteps(HelloWorldCookie cookie)
        {
            Assert.IsNotNull(cookie);
            Assert.IsNotNull(cookie.FlowLogs);
            Assert.IsTrue(cookie.FlowLogs.Count > 0);

            // Check each step is in order
            Assert.IsTrue(cookie.FlowLogs[0].Contains("Mixing"));
            Assert.IsTrue(cookie.FlowLogs[1].Contains("Laminating"));
            Assert.IsTrue(cookie.FlowLogs[2].Contains("Forming"));
            Assert.IsTrue(cookie.FlowLogs[3].Contains("Baking"));
            Assert.IsTrue(cookie.FlowLogs[4].Contains("Filling"));
            Assert.IsTrue(cookie.FlowLogs[5].Contains("Cooling"));
            Assert.IsTrue(cookie.FlowLogs[6].Contains("Freezing"));
            Assert.IsTrue(cookie.FlowLogs[7].Contains("pack"));
        }
    }
}
