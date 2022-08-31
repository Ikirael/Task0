/*
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] CreateMatrixRndInt (int row, int col, int min, int max)
{
    int[,] matrix = new int[row,col];
    for (int i = 0; i < row; ++i) //array.GetLength(0)
    {
        for (int j = 0; j < col; ++j) //array.GetLength(1)
            matrix[i,j] = new Random().Next(min, max + 1);
    }
    return matrix;
}

void PrintArray (int[] array)
{
    for(int i = 0; i < array.Length; ++i)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}