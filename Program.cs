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
            SayGoodbye("Max");
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi, {0}!", name);
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, {0}", name);
        }
    }
}
