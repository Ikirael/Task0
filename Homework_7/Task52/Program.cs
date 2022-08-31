/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); ++i)
    {
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); ++j)
            Console.Write($"{array[i,j], 2} ");

        Console.WriteLine("]");
    }
}

void AverageMatrixCol(int[,] matrix)
{
    double avr=0;

    for(int j = 0; j < matrix.GetLength(1); ++j)
    {
        for(int i = 0; i < matrix.GetLength(0); ++i)
            avr = avr + matrix[i,j];
        avr = avr/matrix.GetLength(0);
        Console.Write($"{Math.Round(avr, 2)}; ");
    }

}

int[,] matrix = CreateMatrixRndInt(3, 5);
PrintArray(matrix);
AverageMatrixCol(matrix);