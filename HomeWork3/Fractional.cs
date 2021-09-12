using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Task3
{
    public class Fractional
    {
        /// <summary>
        /// числитель
        /// </summary>
        private int numerator;

        /// <summary>
        /// знаменатель
        /// </summary>
        private int denominator;

        public int Numerator 
        {
            get { return numerator; }
            set { numerator = value; } 
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Ошибочный ввод нуля в знаменателе");
                }
                else denominator = value;
            }
        }
        public double DecimalState { get; private set; }

        public static Fractional operator +(Fractional a, Fractional b)
        {
            Fractional result = new Fractional();

            result.numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            result.Denominator = a.denominator * b.denominator;
            result.DecimalState = (double)result.numerator / result.denominator;
            return result;
        }

        public static Fractional operator -(Fractional a, Fractional b)
        {
            Fractional result = new Fractional();

            result.numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            result.Denominator = a.denominator * b.denominator;
            result.DecimalState = (double)result.numerator / result.denominator;
            return result;
        }

        public static Fractional operator *(Fractional a, Fractional b)
        {
            Fractional result = new Fractional();

            result.numerator = a.numerator * b.numerator;
            result.Denominator = a.denominator * b.denominator;
            result.DecimalState = (double)result.numerator / result.denominator;
            return result;
        }

        public static Fractional operator /(Fractional a, Fractional b)
        {
            Fractional result = new Fractional();

            result.numerator = a.numerator * b.denominator;
            result.Denominator = a.denominator * b.numerator;
            result.DecimalState = (double)result.numerator / result.denominator;
            return result;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
