using Extensioner.Logging;
using System;

namespace NETCore21
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Hello World!");
            Log.Debug("Hello World!");
            Log.Error("Hello World!", new Exception("NETCore21,Hello World!"));
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
