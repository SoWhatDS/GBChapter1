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

            Console.WriteLine("\t\t\tTask 1 Написать программу сложения двух чисел");

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

            #region Task2 Вывести значение функции ax^2+bx+c в точке x. x — ввести с клавиатуры, a,b и c — присвоить в программе.

            Console.WriteLine("\t\t\tTask 2 Вывести значение функции ax^2+bx+c в точке x.");

            int a = 1;
            int b = 1;
            int c = 1;
            int x;

            Console.Write("введите значение x: ");

            x = CanParse(Console.ReadLine());
            double funcValue = a * Math.Pow(x, 2) + b * x + c;

            Console.Write($"Значение функции {a} * x^2 + {b}*x + {c}, при x равным: {x}, будет равно {funcValue}");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        #region Вспомогательные методы 
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
                Console.WriteLine();
            }

            return userInputNumber;
        }

        static int Sum(int a,int b)
        {
            return a + b;
        }
        #endregion
    }
}

                 


 