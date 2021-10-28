using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
namespace Week2_05
{
    class Program
    {
        private static string x = "";
        private static int exitflag = 0;
        private static int updateFlag = 0;

        static void ThReadX()
        {
            while (exitflag == 0)
            {
                if (x != "exit")
                {
                    Console.WriteLine("***Thread {0} : X = {1}***", i, x);
                }
            }
            Console.WriteLine("---Thread {0} exit---", i);
        }

        static void ThWriteX()
        {
            string xx;
            while (exitflag == 0)
            {
                Console.Write("Input: ");
                xx = Console.ReadLine();
                if (xx == "exit")
                    exitflag = 1;
                else
                    x = xx;
            }
        }

        static void Main(string[] args)
        {
            Thread A = new Thread(new ThreadStart(ThWriteX));
            Thread B = new Thread(new ThreadStart(ThReadX));
            Thread C = new Thread(new ThreadStart(ThReadX));
            Thread D = new Thread(new ThreadStart(ThReadX));

            A.Start();
            B.Start();
            C.Start();
            D.Start();
        }
    }
}
