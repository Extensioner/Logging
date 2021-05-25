using Extensioner.Logging;
using System;

namespace NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Hello World!");
            Log.Debug("Hello World!");
            Log.Error("Hello World!", new Exception("NET5,Hello World!"));
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
