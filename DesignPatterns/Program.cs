using System;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();

            // Both will be same as they are same object return by GetInstance method
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Singleton logger class
    /// </summary>
    public class Logger
    {
        private static Logger logger;

        // Make constructor private so that outisde cannot initialize it
        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if(logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
    }
}
