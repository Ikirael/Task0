/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;

Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1; //нулевая степень числа равна 1

Console.Write("Введите степень числа A: ");
int degree = Convert.ToInt32(Console.ReadLine());

for (int i=1; i <= degree; ++i){
    result = result * number;
}

Console.Write($"Число {number} в степени {degree} равно {result} ");