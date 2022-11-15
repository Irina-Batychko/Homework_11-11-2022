/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.WriteLine("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine (max + " большее число");