using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Task3
{

    class Program
    {
        static void Main(string[] args)
        {
            Fractional a = new Fractional();
            Fractional b = new Fractional();

            a.Numerator = ReadInt("Введите числитель первой дроби", false);
            a.Denominator = ReadInt("Введите знаменатель первой дроби", true);

            b.Numerator = ReadInt("Введите числитель второй дроби", false);
            b.Denominator = ReadInt("Введите знаменатель второй дроби", true);

            Fractional sum = a + b;
            Console.WriteLine($"Сложение дробей {a} + {b} = {sum}, в десятичом виде: {sum.DecimalState:#.###}");

            Fractional difference = a - b;
            Console.WriteLine($"Вычитание дробей {a} - {b} = {difference}, в десятичом виде: {difference.DecimalState:#.###}");

            Fractional division = a / b;
            Console.WriteLine($"Деление дробей {a} / {b} = {division}, в десятичом виде: {division.DecimalState:#.###}");

            Fractional multiply = a * b;
            Console.WriteLine($"Умножение дробей {a} * {b} = {multiply}, в десятичом виде: {multiply.DecimalState:#.###}");

            Console.ReadKey();
        }

        /// <summary>
        /// Чтение целого числа с проверкой и выводом сообщения
        /// </summary>
        /// <param name="command">текстовое сообщение</param>
        /// <param name="isDenominator">вводим ли мы знаменатель?</param>
        /// <returns></returns>
        static int ReadInt(string command, bool isDenominator)
        {
            bool isRightInput;
            int result;
            do
            {
                Console.WriteLine(command);

                isRightInput = int.TryParse(Console.ReadLine(), out result);

                if (isRightInput && isDenominator)
                {
                    if (result == 0) isRightInput = false;
                }
            } 
            while (!isRightInput);
            return result;
        }   
    }
}

