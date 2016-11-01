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


        public void LilleLommeregner()
        {
            this.userinput1 = 0;
            this.useroperator = "+";
            this.userinput2 = 0;
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
    }
}
