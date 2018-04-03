using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCsharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var v = new TestClassLibrary.Class1())
            {
                Console.WriteLine($"Hello World. {v.GetValue()}");
            }
            Console.ReadLine();
        }
    }
}
