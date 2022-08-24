/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SumOddIndxArray (int[] array)
{
    int sum=0;
    for(int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];

    return sum;    
    
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size,-100,100);
PrintArray(array);

Console.WriteLine($"Сумма элементов на нечетных индексах: {SumOddIndxArray(array)}");