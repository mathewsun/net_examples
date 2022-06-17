using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread((ThreadStart)ObliviousFunction);
            Thread thread2 = new Thread((ThreadStart)BlindFunction);

            thread1.Start();
            thread2.Start();

            while (true)
            {
                // Stare at the two threads in deadlock.
            }


            Console.WriteLine("Hello World!");
        }


        static object object1 = new object();
        static object object2 = new object();

        public static void ObliviousFunction()
        {
            lock (object1)
            {
                Thread.Sleep(1000); // Wait for the blind to lead
                lock (object2)
                {
                }
            }
        }

        public static void BlindFunction()
        {
            lock (object2)
            {
                Thread.Sleep(1000); // Wait for oblivion
                lock (object1)
                {
                }
            }
        }

        //static void Main()
        //{

        //}
    }
}
