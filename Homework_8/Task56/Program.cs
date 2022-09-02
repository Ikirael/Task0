/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixRndInt (int row, int col)
{
    int[,] matrix = new int[row,col];
    for (int i = 0; i < row; ++i) //array.GetLength(0)
    {
        for (int j = 0; j < col; ++j) //array.GetLength(1)
            matrix[i,j] = new Random().Next(0,10);
    }
    return matrix;
}

void PrintMatrix (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); ++i)
    {
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); ++j)
            Console.Write($"{array[i,j], 1} ");

        Console.WriteLine("]");
    }
}

int SumRow(int[,] matrix, int row)
{
    int sum = 0;
    for(int j = 0; j < matrix.GetLength(1); ++j)
        sum += matrix[row, j];
    
    return sum;
}

void FindMinRow (int[,] matrix)
{
    int sum;
    int minSum = SumRow(matrix, 0);
    int minRow=0;
    for(int i = 1; i < matrix.GetLength(0); ++i)
    {
        sum = SumRow(matrix,i);
        if(sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов расположена в {minRow+1} строке.");
}

int[,] matrix = CreateMatrixRndInt(4,4);
PrintMatrix(matrix);
FindMinRow(matrix);