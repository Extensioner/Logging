using Extensioner.Logging;
using System;

namespace Linux.Logging
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Log.Info("Hello World!");
                Log.Debug("Hello World!");
                Log.Error("Hello World!", new Exception("出错了"));
                Console.WriteLine("1111");

            }
            catch (Exception ex)
            {
                Console.WriteLine("2222");

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();


        }
    }
}
