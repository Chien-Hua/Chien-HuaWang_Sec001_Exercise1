using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien_HuaWang_Sec001_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {   //a
            Console.WriteLine(Max<int>(8, 2, 4));
            Console.WriteLine(Max<double>(1.6, 2.7, 4.41));
            Console.WriteLine(Max<string>("1.1", "2.3", "4.4"));  
            //b
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(OddSum(intArray));
        }
        public static T Max<T>(T num1, T num2, T num3)
        {
            int result1;
            double result2;

            bool isInt;
            bool isDouble;

            isInt = int.TryParse(num1.ToString(), out result1);
            isDouble = double.TryParse(num1.ToString(), out result2);

            if (isInt)
            {
                int intNum1;
                int intNum2;
                int intNum3;

                int.TryParse(num1.ToString(), out intNum1);
                int.TryParse(num2.ToString(), out intNum2);
                int.TryParse(num3.ToString(), out intNum3);

                if (intNum1 > intNum2)
                {
                    if (intNum1 > intNum3)
                    {
                        return num1;
                    }
                    else
                    {
                        return num3;
                    }
                }
                else
                {
                    if (intNum2 > intNum3)
                    {
                        return num2;
                    }
                    else
                    {
                        return num3;
                    }
                }

            }
            else if (isDouble)
            {
                double doubleNum1;
                double doubleNum2;
                double doubleNum3;

                double.TryParse(num1.ToString(), out doubleNum1);
                double.TryParse(num2.ToString(), out doubleNum2);
                double.TryParse(num3.ToString(), out doubleNum3);

                if (doubleNum1 > doubleNum2)
                {
                    if (doubleNum1 > doubleNum3)
                    {
                        return num1;
                    }
                    else
                    {
                        return num3;
                    }
                }
                else
                {
                    if (doubleNum2 > doubleNum3)
                    {
                        return num2;
                    }
                    else
                    {
                        return num3;
                    }
                }

            }
            return num1;
        }

        public static int OddSum(int[] array)
        {
            int result = 0;
            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    result += number;
                }
            }
            return result;
        }
    }
}
