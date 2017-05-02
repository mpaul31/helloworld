namespace HelloWorld.Client.Logging.Database
{
    public class DatabaseLogger : ILogger
    {
        private readonly string connectionString;

        public DatabaseLogger(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Log(string message)
        {
            // TODO: Use EF, Micro-ORM, ADO.NET, etc.
        }
    }
}
