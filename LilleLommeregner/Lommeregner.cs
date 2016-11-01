using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleLommeregner
{
    class Lommeregner
    {

        public Double userinput1 { get; set; }
        public Double userinput2{ get; set; }
        public string useroperator { get; set; }
        public double svar { get; set; }

        public Double UserInputPlus()
        {
            return userinput1 + userinput2;
        }

        public Double UserInputMinus()
        {
            return userinput1 - userinput2;
        }

        public Double UserInputGange()
        {
            return userinput1 * userinput2;
            
        }

        public Double UserInputDiv()
        {
            return userinput1 / userinput2;
        }


        public void ChoseOperator()
        {
            if (useroperator == "+")
            {
                svar = UserInputPlus();

            }
            else if (useroperator == "-")
            {
                svar = UserInputMinus();
            }
            else if (useroperator == "*")
            {
                svar = UserInputGange();
            }
            else if ( useroperator == "/")
            {
                svar = UserInputDiv();
            }
            
        }
        public void print()
        {
            Console.Write(svar);
        }
    }
}
