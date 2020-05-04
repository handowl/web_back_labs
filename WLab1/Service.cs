using System;
using WLab1.Models;

namespace WLab1
{
    public interface IService {
        int GetFirst();
        int GetSecond();
        int Add();
        int Sub();
        int Mul();
        float Div();
    }
    public class Service: IService
    {
        public Values values;

        public Service()
        {
            values = new Values();
        }

        public int Add() => values.Add();

        public float Div() => values.Div();

        public int GetFirst() => values.firstValue;

        public int GetSecond() => values.secondValue;

        public int Mul() => values.Mul();

        public int Sub() => values.Sub();

    }
}
