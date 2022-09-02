/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
     Console.WriteLine();
}

int[,] MatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
        throw new Exception ("Данные матрицы невозможно перемножить");

    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); ++i)
            for (int j = 0; j < b.GetLength(1); ++j)
                for (int k = 0; k < b.GetLength(0); ++k)
                    result[i,j] += a[i,k] * b[k,j];
    
    return result;
}

Console.Write("Количество строк матрицы А: ");
int aRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов матрицы А: ");
int aCol = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество строк матрицы B: ");
int bRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов матрицы B: ");
int bCol = Convert.ToInt32(Console.ReadLine());

int[,] a = CreateMatrixRndInt(aRow,aCol);
int[,] b = CreateMatrixRndInt(bRow,bCol);

Console.WriteLine("A: ");
PrintMatrix(a);
Console.WriteLine("B: ");
PrintMatrix(b);

Console.WriteLine("AxB: ");
int[,] mul = MatrixMul(a,b);
PrintMatrix(mul);