/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
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

void FindElemMatrix (int[,] matrix, int row, int col)
{
    if(row < matrix.GetLength(0))
        if(col < matrix.GetLength(1))
        {
            Console.WriteLine(matrix[row, col]);
            return;
        }
    Console.WriteLine($"{row+1},{col+1} такого элемента нет");
    return;
}

int[,] matrix = CreateMatrixRndInt(3, 5);
PrintArray(matrix);
Console.WriteLine("Введите позицию элемента");
Console.Write("Строка: ");
int row_elem = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int col_elem = Convert.ToInt32(Console.ReadLine());

FindElemMatrix(matrix, row_elem-1, col_elem-1); //вычитаю единицу с тем учетом, что нумерация строк и столбцов начинается с нуля, но для пользователя привычней с единицы / могу быть неправи и так не стоило делать
