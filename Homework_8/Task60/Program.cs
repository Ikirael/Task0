/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[] ListArray() //создание массива со всеми двузначными числами
{
    int[] array = new int[90];
    for(int i=0; i<array.Length; ++i)
    {
        array[i]=10+i;
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; ++i)
        Console.Write($"{array[i]} ");
}

int[] DelElemArray(int[] array, int elem) //удаление значения, которое уже внесено в трехмерный массив
{
    bool j=true;
    int[] newArray = new int[array.Length-1];
    for(int i=0; i<newArray.Length; ++i)
    {
        if (i == elem) j = false;
        if (j) newArray[i] = array[i];
        else newArray[i] = array[i+1];  
       
    }

    return newArray;
}

int[,,] Create3DimArray (int x, int y, int z)
{
    int[] list = ListArray();
    int count = 89; // переменная, необходимая для уменьшения списка неиспользуемых двузначных значений
    int elem;
    int[,,]  arr3 = new int[x,y,z];
    for (int i = 0; i < x; ++i) //array.GetLength(0)
    {
        for (int j = 0; j < y; ++j) //array.GetLength(1)
            for (int k = 0; k < z; ++k)
            {
                elem = new Random().Next(10,count);
                arr3[i,j,k] = list[elem];
                list = DelElemArray(list,elem);
                --count;
            }
    }
    return arr3;
}

void Print3DimArray (int[,,] arr3)
{
    for(int k = 0; k < arr3.GetLength(2); ++k)
    {
        for(int i = 0; i < arr3.GetLength(0); ++i)
        {
            for(int j = 0; j < arr3.GetLength(1); ++j)
                Console.Write($"{arr3[i,j,k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}



int[,,] arr3 = Create3DimArray(2,2,2);
Print3DimArray(arr3);
