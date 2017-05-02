using HelloWorld.Client.Logging;
using HelloWorld.Client.Logging.Console;

namespace HelloWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = CreateLogger();

            logger.Log("Hello World");

            System.Console.ReadLine();
        }

        // Factory Method
        static ILogger CreateLogger()
        {
            // Typically in a real-world application we would setup our dependencies 
            // in our composition root using a DI framework (Ninject, Windsor, Unity, SimpleInjector, etc).
            return new ConsoleLogger(System.Console.Out);
        }
    }
}
