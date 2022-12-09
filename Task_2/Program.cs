/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using static System.Console;

WriteLine("Определите границы промежутка (два числа): ");
int M = Convert.ToInt32(ReadLine());
int N = Convert.ToInt32(ReadLine());

int SumInterval(int x, int y)
{
    if (x == y) return x;
    else return (x + SumInterval(x + 1, y));
}

WriteLine(SumInterval(M, N));