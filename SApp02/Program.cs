using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{

    /// <summary>
    /// Комплексное число
    /// </summary>
    struct Complex
    {

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая чатсь комплексного числа
        /// </summary>
        public double im; // private

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;

            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;

            return y;
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
            object o;
            int i = 12;
            Complex complex01;
            complex01.re = 3;
            complex01.im = 2;

            Complex complex02;
            complex02.re = -2;
            complex02.im = 7;

            Complex complex03 = complex01.Plus(complex02);

            Console.WriteLine(i);
            Console.WriteLine(complex03.ToString());

            Console.WriteLine($"Число {complex01} + {complex02} = {complex03}");

            Console.ReadLine();

        }
    }
}
