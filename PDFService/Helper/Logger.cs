using el = Microsoft.Practices.EnterpriseLibrary.Logging;
namespace PDFService.Helper
{
    /// <summary>
    /// Logging class
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Log messages
        /// </summary>
        /// <param name="message">messages to be logged</param>
        public static void LogMessage(string message)
        {
            el.Logger.SetLogWriter(new el.LogWriterFactory().Create());
            var log = new el.LogEntry();
            log.Message = message;
            el.Logger.Write(log);
        }
    }
}