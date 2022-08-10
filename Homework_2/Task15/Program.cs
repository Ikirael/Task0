/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
using System;

Console.WriteLine("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day <= 0) Console.WriteLine("Такого дня недели не существует");
else if (day == 6 || day == 7) Console.WriteLine("Да, это выходной");
else Console.WriteLine("Нет, это не выходной");