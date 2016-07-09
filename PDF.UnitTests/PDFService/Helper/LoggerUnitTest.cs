using System;
using PDFService.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace PDF.UnitTests.PDFService.Helper
{
    /// <summary>
    /// Unit test class for Logger helper utility
    /// </summary>
    [TestClass]
    public class LoggerUnitTest
    {
        /// <summary>
        /// Log message to file successful test
        /// </summary>
        [TestMethod]
        public void LogMessageToFile()
        {
            Logger.LogMessage("Test message recorded");

            var stream = new StreamReader("trace-xml.log");
            var content = stream.ReadToEnd();
            Assert.IsFalse(string.IsNullOrWhiteSpace(content));
        }
    }
}
