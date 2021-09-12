using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{

    /// <summary>
    /// Комплексное число
    /// </summary>
    class Complex
    {
        #region Private Fields

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая чатсь комплексного числа
        /// </summary>
        private double im { get; set; } // private

        #endregion

        #region Public Properties

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                //if (value == 0)
                //{
                //    throw new Exception("На ноль делить нельзя!");
                //}
                re = value;
            }
        }


        #endregion

        #region Constructors

        public Complex()
        {

        }

        public Complex(double re, double im)
        {
            if (im == 0)
            {
                throw new Exception("На ноль делить нельзя!");
            }
            this.re = re;
            this.im = im;
        }

        #endregion

        public void SetIm(double im)
        {
            this.im = im;
        }

        public double GetIm()
        {
            return im;
        }

        public Complex Plus(Complex x)
        {
            Complex y = new Complex(re + x.re, im + x.im);
            return y;
        }

        public Complex Minus(Complex x)
        {
            return new Complex(re - x.re, im - x.im);
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex01 = new Complex(5, 0);
            //complex01.SetIm(2);
            complex01.Re = 0;
            Console.WriteLine(complex01.Re);

            complex01 = new Complex(1, 1);
            //complex01.re = 5;
            //complex01.im = 0;
        }
    }
}
