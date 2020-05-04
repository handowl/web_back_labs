using System;
namespace WLab1.Models
{
    public class Values
    {
        public int firstValue, secondValue;
        public Values()
        {
            Random random = new Random();
            firstValue = random.Next(0, 10);
            secondValue = random.Next(0, 10);
        }

        public int Add() => firstValue + secondValue;
        public int Sub() => firstValue - secondValue;
        public int Mul() => firstValue * secondValue;
        public float Div()
        {
            float div;
            try
            {
                div = (float) firstValue / secondValue;
            }
            catch (DivideByZeroException)
            {
                div = float.MaxValue;
            }
            return div;
            
        }
    }
}
