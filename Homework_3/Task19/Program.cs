/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using System;

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if( (number%10) != (number/10000)) 
    Console.WriteLine("нет");
else if  ( (number / 10 % 10) != (number / 1000 % 10) )
    Console.WriteLine("нет");
else 
    Console.WriteLine("да");
