using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleLommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Lommeregner l1 = new Lommeregner(4, "+", 4);
            Console.WriteLine(l1.UserInputPlus());
        }
    }
}
