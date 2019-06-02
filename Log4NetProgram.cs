using System;
using log4net;

namespace PiyushApps.Log4NetApp
{
    class Log4NetProgram
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            Logger.Debug("This is a Debug message");
            Logger.Info("This is a Info message");
            Logger.Warn("This is a Warning message");
            Logger.Error("This is an Error message");
            Logger.Fatal("This is a Fatal message");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            Logger.Debug("This is a Debug message");
            Logger.Info("This is a Info message");
            Logger.Warn("This is a Warning message");
            Logger.Error("This is an Error message");
            Logger.Fatal("This is a Fatal message");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}
