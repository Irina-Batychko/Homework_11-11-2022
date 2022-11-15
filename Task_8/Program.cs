/*Задача №8
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */

Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

int N = 2;

while (N <= a)
{
    Console.WriteLine(N);
    N = N + 2;
}

