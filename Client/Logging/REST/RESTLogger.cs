namespace HelloWorld.Client.Logging.REST
{
    public class RESTLogger : ILogger
    {
        private readonly string uri;

        public RESTLogger(string uri)
        {
            this.uri = uri;
        }

        public void Log(string message)
        {
            // TODO: Use System.Net.Http, REST Sharp, etc.
        }
    }
}
