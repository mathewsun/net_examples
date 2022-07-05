using System;
using System.Threading;

namespace Polymorphism
{
    internal class Program
    {

        class A
        {
            public void Publish() { }
            public virtual void Print() { Console.WriteLine("Print A"); }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("Print B");
            }
        }

        static void Main(string[] args)
        {
            A parentElement = new B();

            parentElement.Print();

            Console.WriteLine("Hello World!");
        }
    }
}