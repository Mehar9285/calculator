using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division
    {
        public static double ToDivide(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();
            return num1 / num2;
        }
    }
}
