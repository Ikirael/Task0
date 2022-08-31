/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateMatrixRndInt (int row, int col)
{
    double[,] matrix = new double[row,col];
    for (int i = 0; i < row; ++i) //array.GetLength(0)
    {
        for (int j = 0; j < col; ++j) //array.GetLength(1)
        {
            matrix[i,j] = new Random().NextDouble()*100;
            matrix[i,j] = Math.Round(matrix[i,j], 2);
        }
    }
    return matrix;
}

void PrintArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); ++i)
    {
        Console.Write("[");
        for(int j = 0; j < array.GetLength(1); ++j)
            Console.Write($"{array[i,j], 6} ");

        Console.WriteLine("]");
    }
}


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateMatrixRndInt(row,col);
PrintArray(matrix);