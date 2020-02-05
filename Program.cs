using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git___Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Max");
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi, {0}!", name);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
