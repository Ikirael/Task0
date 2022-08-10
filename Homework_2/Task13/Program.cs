/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

using System;

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = Math.Abs(number); //если число отрицательное

if(n < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while(n/1000 > 0)
    {
        n = n/10;
    }
    n = n%10;
    Console.WriteLine($"Третья цифра числа {number} => {n}");
}