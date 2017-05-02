using System.IO;

namespace HelloWorld.Client.Logging.Console
{
    public class ConsoleLogger : ILogger
    {
        private readonly TextWriter output;

        public ConsoleLogger(TextWriter output)
        {
            this.output = output;
        }

        public void Log(string message)
        {
            this.output.Write(message);
        }
    }
}
