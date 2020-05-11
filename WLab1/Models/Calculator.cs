using System;
namespace WLab1.Models
{
    public class Calculator
    {
        public Calculator()
        {
        }
        public Calculator(int first, string operation, int second)
        {
            First = first;
            Operation = operation;
            Second = second;
        }

        public int First { get; set; }
        public string Operation { get; set; }
        public int Second { get; set; }

        public float Result { get; set; }

        public static float Calculate(int first, string operation, int second)
        {
            float result;

            switch (operation)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    try
                    {
                        result = first / second;
                    }
                    catch (DivideByZeroException)
                    {
                        result = float.MaxValue;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
