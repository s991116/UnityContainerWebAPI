using System.Net.Http;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiTest;

namespace TestWebApiTest
{
    [TestClass]
    public class TcWebApi
    {
        private static TestServer _server;

        [ClassInitialize]
        public static void FixtureInit(TestContext t)
        {
            _server = TestServer.Create<Startup>();
        }

        [ClassCleanup]
        public static void FixtureDispose()
        {
            _server.Dispose();
        }

        [TestMethod]
        public void WebApiGetTest()
        {
            //Arrange

            //Act
            var response = _server.HttpClient.GetAsync("/api/time").Result;

            //Assert
            var result = response.Content.ReadAsAsync<string>().Result;
            Assert.AreEqual("hello world", result);
        }
    }
}
