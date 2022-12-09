/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

using static System.Console;

WriteLine("Определите границу промежутка: ");
int number = Convert.ToInt32(ReadLine());

string Interval(int x)
{
    if (x == 1) return x.ToString();
    else return (x + ", " + Interval(x - 1));
}

WriteLine(Interval(number));