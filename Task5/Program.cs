﻿/*
Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

using System;

Console.WriteLine("Введите целое число N: "); //Предположительно число должно быть неотрицательным, иначе алгоритм программы должен быть другим. Так как в тз не указано ничего по этому поводу, буду считать, что N положительное.
int N = Convert.ToInt32(Console.ReadLine());

for(int i = -N; i < N; ++i)
{
    Console.Write($"{i}, ");
}

    Console.Write(N); //После последнего числа запятая не стоит, поэтому выводится отдельно