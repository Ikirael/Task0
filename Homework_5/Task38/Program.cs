/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

double[] CreateArrayRndInt (int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; ++i)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}

void PrintArray (double[] array)
{
    for(int i = 0; i < array.Length; ++i)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

double DiffMaxMinArray (double[] array)
{
    double max = array[0];
    double min = array[0];

    for(int i = 0; i < array.Length; ++i)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }

    Console.WriteLine($"Максимальный элемент равен {max}");
    Console.WriteLine($"Минимальный элемент равен {min}");

    double diff = max - min;
    return diff;    
    
}


Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndInt(size);
PrintArray(array);

Console.WriteLine($"Разница между максимальным и минимальным эл-ами равна: {DiffMaxMinArray(array)}");