/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; ++i)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for(int i = 0; i < array.Length; ++i)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int QuaEvNumArray (int[] array)
{

    int cnt = 0; 
    for(int i = 0; i < array.Length; ++i)
    {
        if( array[i]%2 == 0 ) ++cnt;
    }
    return cnt;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size,100,999);
PrintArray(array);

Console.WriteLine($"В данном массиве {QuaEvNumArray(array)} четных элементов");