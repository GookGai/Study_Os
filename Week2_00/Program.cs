using System;
using System.Diagnostics;


namespace Week2_01
{
    class Program
    {
        private static int sum = 0;
        //private static object _Lock = new object();

        static void plus()
        {
            int i = 0;
            //lock (_Lock)
            {
                for (i = 1; i < 1000001; i++)
                    sum += i;
            }
        }

        static void minus()
        {
            int i = 0;
            //lock (_Lock)
            {
                for (i = 0; i < 1000000; i++)
                    sum -= i;
            }
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Start...");
            sw.Start();
            plus();
            minus();
            sw.Stop();
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
        }
    }
}
