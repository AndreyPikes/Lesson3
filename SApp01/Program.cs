using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    class Program
    {


        static bool Sample2(out int a)
        {
            a = 1;
            return true;
        }

        static void Sample(ref int x, ref int y, ref int z, string s)
        {
            // Process ...
            x = 1;
            y = 0;
            z = 2;
        }
        
        static void Main(string[] args)
        {
            object o;
            int a =1;
            int b = -5;
            int c = 5;
            string str = "Hello!";
            string str2 = (string)str.Clone();
            string str3 = string.Copy(str);
            str2 = str;

            Sample(ref a, ref b, ref c, string.Copy(str));


            Console.Write("Введите число: ");

            //int number = int.Parse(Console.ReadLine());
            int i;

            if (int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine($"Вы ввели чило {i}");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число.");
            }



            Console.ReadLine();

        }
    }
}
