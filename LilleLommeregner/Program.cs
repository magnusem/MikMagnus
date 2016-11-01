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
            bool sandt = true;
            while (sandt)
            {
                Console.Clear();

                Console.WriteLine("Skriv et tal");
                string input1 = Console.ReadLine();
                if (input1 == "stop")
                {
                    break;
                }
                double userinput1 = Double.Parse(input1);
                l1.userinput1 = userinput1;



                Console.WriteLine("hvad vil du gerne + - * /");
                string useroperator = Console.ReadLine();
                if (useroperator == "stop")
                {
                    break;
                }
                l1.useroperator = useroperator;


                Console.WriteLine("skriv det andet tal");
                string input2 = Console.ReadLine();
                if (input2 == "stop")
                {
                    break;
                }
                double userinput2 = Double.Parse(input2);
                l1.userinput2 = userinput2;
                l1.ChoseOperator();
                Console.Clear();
                Console.WriteLine($"{l1.userinput1} {l1.useroperator} {l1.userinput2} ");
                Console.WriteLine("=");
                l1.print();
                Console.WriteLine();
                Console.WriteLine("\nhvis du ønsker at stoppe skriv \"stop\"");
                Console.ReadKey();
            }


            Console.ReadKey();
            
        }
    }
}
