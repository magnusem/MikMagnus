﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleLommeregner
{
    class Lommeregner
    {
        //public double userinput1;
        //public string useroperator;
        //public double userinput2;

        //public Lommeregner()
        //{
        //    this.userinput1 = userinput1;
        //    this.useroperator = useroperator;
        //    this.userinput2 = userinput2;
        //}

        public Double userinput1 { get; set; }
        public Double userinput2{ get; set; }
        public string useroperator { get; set; }
        public double svar { get; set; }

        public void UserInputPlus()
        {
            double sumplus = userinput1 + userinput2;
            Console.WriteLine(sumplus);
        }

        public void UserInputMinus()
        {
            double summinus = userinput1 - userinput2;
            Console.WriteLine(summinus);
        }

        public void UserInputGange()
        {
            double sumgange = userinput1 * userinput2;
            Console.WriteLine(sumgange);
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
            else if (useroperator == "*")
            {
                UserInputGange();
            }
        }
    }
}
