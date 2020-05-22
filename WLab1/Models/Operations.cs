using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WLab1.Models
{
    public class Exercises
    {
        public string First { get; set; }
        public string Second { get; set; }
        public string Operation { get; set; }
        public string CorrectAnswer { get; private set; }
        public string InputAnswer { get; set; }

        public Exercises()
        {
            Random rnd = new Random();
            double first = rnd.Next(10);
            double second = rnd.Next(9)+1;
            Operation = new List<string> { "+", "-", "*", "/"}[rnd.Next(4)];
            First = first.ToString();
            Second = second.ToString();
        }

        public void Solve()
        {
            switch (Operation)
            {
                case "+":
                    CorrectAnswer = (Convert.ToDouble(First) + Convert.ToDouble(Second)).ToString();
                    break;
                case "-":
                    CorrectAnswer = (Convert.ToDouble(First) + Convert.ToDouble(Second)).ToString();
                    break;
                case "*":
                    CorrectAnswer = (Convert.ToDouble(First) / Convert.ToDouble(Second)).ToString();
                    break;
                case "/":
                    CorrectAnswer = (Convert.ToDouble(First) / Convert.ToDouble(Second)).ToString();
                    break;

            }
        }

        public bool Check()
        {
            if (Operation == "/" & Math.Abs(Convert.ToDouble(InputAnswer) - Convert.ToDouble(CorrectAnswer)) < 0.5) return true;
            if (InputAnswer == CorrectAnswer) return true;
            return false;
        }

    }

    public sealed class Answers
    {
        public List<Exercises> Exercises;

        public int Correct { get; set; }
        public int Total { get; set; }
        private Answers()
        {
            Correct = Total = 0;
            Exercises = new List<Exercises>();
        }

        public static Answers Instance { get; } = new Answers();
    }
}