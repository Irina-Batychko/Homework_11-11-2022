﻿/*Задача №4
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int n = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (n > max)
{
    max = n;
}
Console.WriteLine("Максимальное число из трех " + " " + max);

