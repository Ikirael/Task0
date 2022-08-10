/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

using System;

Console.WriteLine("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max;
if (a > b) max = a;
else max = b;

Console.WriteLine($"max = {max}");
