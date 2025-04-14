using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GBChepter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 Написать программу сложения двух чисел.

            int _firstNumber;
            int _secondNumber;
            int _sum;
  
            Console.Write("Введите первое число: ");

            _firstNumber = CanParse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            _secondNumber = CanParse(Console.ReadLine());

            _sum = Sum(_firstNumber, _secondNumber);

            Console.Write($"Сумма чисел равна: {_sum}");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        static int CanParse(string userInput)
        {
            int userInputNumber;

            if (Int32.TryParse(userInput, out int inputNumber))
            {
                userInputNumber = inputNumber;
            }
            else
            {
                Console.Write("Недопустимое значение!!! Значению присвоен ноль");
                userInputNumber = 0;
            }

            return userInputNumber;
        }

        static int Sum(int a,int b)
        {
            return a + b;
        }
    }
}

                 


 