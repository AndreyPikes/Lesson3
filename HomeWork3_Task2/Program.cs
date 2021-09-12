using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            bool isRightInput;
            int currentNumber;
            List<int> selectedNumbers = new List<int>();

            Console.WriteLine("Введите последовательность чисел через ENTER, 0 - последнее число");            
            do
            {                
                isRightInput = int.TryParse(Console.ReadLine(), out currentNumber);

                if (isRightInput && currentNumber > 0 && (currentNumber % 2 != 0))
                {
                    selectedNumbers.Add(currentNumber);
                    summ += currentNumber;
                }
            }
            while (currentNumber != 0);

            Console.WriteLine("Результат:");

            foreach (var item in selectedNumbers)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine($"Сумма: {summ}");

            Console.ReadLine();
        }
    }
}
