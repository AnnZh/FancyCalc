using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            double x = a;
            double y = b;
            return x + y;
        }


        public double Subtract(int a, int b)
        {
            double x = a;
            double y = b;
            return x - y;
        }


        public double Multiply(int a, int b)
        {
            double x = a;
            double y = b;
            return x * y;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            char[] arr = new char[] { '+', '-', '*', '/' };
            char str = ' ';
            double x = 0;
            double y = 0;
            double z = 0;
            string[] words = new string[2];

            foreach (char i in expression)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i == arr[j])
                    {
                        str = arr[j];
                        words = expression.Split(new char[] { str });
                    }
                }
            }
       
            x = Convert.ToDouble(words[0].Trim());
            y = Convert.ToDouble(words[1].Trim());

            switch (str)
            {
                 case '-':
                    z = x - y;
                    break;
                 case '+':
                    z = x + y;
                    break;
                 case '*':
                    z = x * y;
                    break;
                case '/':
                    if (y == 0)
                        throw new DivideByZeroException();
                    z = x / y;
                    break;
                default:
                     break;
            }
            
               return z;
        }
    }
}
