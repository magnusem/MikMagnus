using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleLommeregner
{
    class Lommeregner
    {
        public double userinput1;
        public string useroperator;
        public double userinput2;

        //public Lommeregner()
        //{
        //    this.userinput1 = userinput1;
        //    this.useroperator = useroperator;
        //    this.userinput2 = userinput2;
        //}

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
