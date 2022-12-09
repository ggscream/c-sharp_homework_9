/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using static System.Console;



int Akkerman(int number_1, int number_2)
{
    if (number_1 == 0) return number_2 + 1;
    if (number_1 > 0 && number_2 == 0) return Akkerman(number_1 - 1, 1);
    else return Akkerman(number_1 - 1, Akkerman(number_1, number_2 - 1));
}

WriteLine("Введите два неотрицательных числа: ");
int M = Convert.ToInt32(ReadLine());
int N = Convert.ToInt32(ReadLine());

if (M < 0 || N < 0) WriteLine("Введите положительные числа!");
else WriteLine(Akkerman(M, N));
