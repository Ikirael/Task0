/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateMatrixRndInt (int row, int col)
{
    int[,] matrix = new int[row,col];
    for (int i = 0; i < row; ++i) //array.GetLength(0)
    {
        for (int j = 0; j < col; ++j) //array.GetLength(1)
            matrix[i,j] = new Random().Next(0,100);
    }
    return matrix;
}

void PrintMatrix (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); ++i)
    {
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); ++j)
            Console.Write($"{array[i,j], 2} ");

        Console.WriteLine("]");
    }
}

int[] ConvertMatrix2ArrayRow(int[,] matrix, int row)
{
    int[] result = new int[matrix.GetLength(1)];
    for(int j=0; j<matrix.GetLength(1); ++j)
        result[j] = matrix[row,j];

    Array.Sort(result);
    return result;
}

void PrintArray (int[] array)
{
    for(int i = 0; i < array.Length; ++i)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int[,] SortRowMatrix (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int max_col = matrix.GetLength(1);
    for(int i=0; i<matrix.GetLength(0); ++i)
    {
        array = ConvertMatrix2ArrayRow(matrix,i);
        for(int j=0; j<matrix.GetLength(1); ++j)
            matrix[i,j] = array[max_col - j - 1];
    }
    return matrix;
}


Console.WriteLine("Оригинальный массив: ");
int[,] matrix = CreateMatrixRndInt(4,3);
PrintMatrix(matrix);

Console.WriteLine("");
Console.WriteLine("Отсортированный массив: ");

matrix = SortRowMatrix(matrix);
PrintMatrix(matrix);
