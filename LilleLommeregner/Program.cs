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
            double userinput1 = Double.Parse(input1);
            l1.userinput1 = userinput1;


            Console.WriteLine("hvad vil du gerne +-*");
            string useroperator = Console.ReadLine();
            l1.useroperator = useroperator;


            Console.WriteLine("Tal 2");
            string input2 = Console.ReadLine();
            double userinput2 = Double.Parse(input2);
            l1.userinput2 = userinput2;
            l1.ChoseOperator();
            l1.print();

            Console.ReadKey();
            
        }
    }
}
