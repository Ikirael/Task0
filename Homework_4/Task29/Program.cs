/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

using System;

int[] arr = new int[8];

Console.WriteLine("Заполните массив: ");

for(int i = 0; i < arr.Length; ++i){
    Console.Write($"{i} элемент: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Вывод массива: [");
for(int i = 0; i < arr.Length-1; ++i)
    Console.Write($"{arr[i]}, ");

Console.WriteLine($"{arr[7]}]");