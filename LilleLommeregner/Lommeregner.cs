using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleLommeregner
{
    class Lommeregner
    {
        private double userinput1;
        private string useroperator;
        private double userinput2;


        public Lommeregner(double userinput1, string useroperator, double userinput2)
        {
            this.userinput1 = userinput1;
            this.useroperator = useroperator;
            this.userinput2 = userinput2;
        }

        public double UserInputPlus()
        {
            double sumplus = userinput1 + userinput2;
            return sumplus;
        }

        public double UserInputMinus()
        {
            double summinus = userinput1 - userinput2;
            return summinus;
        }

        //public double

        public void ChoseOperator()
        {
            if (useroperator == "+")
            {
                UserInputPlus();
            }
            else if (useroperator == "-")
            {
                UserInputMinus();
            }
        }
    }
}
