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
            Lommeregner l1 = new Lommeregner();

            Console.WriteLine("Tal 1");
            string input1 = Console.ReadLine();
            double userinput1 = Int32.Parse(input1);

            

            Console.WriteLine("Tal 2");
            string input2 = Console.ReadLine();
            double userinput2 = Int32.Parse(input2);
            
            Console.WriteLine(l1.UserInputPlus());
        }
    }
}
