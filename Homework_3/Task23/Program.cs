/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i=1; i < number; ++i){
    int result = i*i*i;
    Console.Write($"{result}, ");
}
    Console.WriteLine(number*number*number); //чтобы после последнего числа не стояла запятая, я вывел его отдельно