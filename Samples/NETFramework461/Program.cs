using Extensioner.Logging;
using System;

namespace NETFramework461
{
    class Program
    {
        static void Main(string[] args)
        {

            Log.Info("Hello World!");
            Log.Debug("Hello World!");
            Log.Error("Hello World!", new Exception("NETFramework461,Hello World!"));
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
