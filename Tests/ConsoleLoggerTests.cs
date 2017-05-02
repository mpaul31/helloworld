using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Client.Logging;
using HelloWorld.Client.Logging.Console;

namespace HelloWorld.Tests
{
    [TestClass]
    public class ConsoleLoggerTests
    {
        [TestMethod]
        public void Can_Log()
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();

            ILogger logger = new ConsoleLogger(sw);

            logger.Log("Hello World");

            Assert.AreEqual("Hello World", sw.ToString());
        }
    }
}
