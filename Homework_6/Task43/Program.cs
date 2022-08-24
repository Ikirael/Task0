/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int CntPos (int amt)
{
    int cnt = 0;
    int num;
    Console.WriteLine("Вводите числа (через Enter): ");
    for(int i = 0; i < amt; ++i)
    {
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) ++cnt;
    }
    Console.WriteLine();
    
    return cnt;
}

Console.Write("Введите количество чисел: ");
int amt = Convert.ToInt32(Console.ReadLine());
int cnt = CntPos(amt);
Console.WriteLine($"Количество положительных чисел: {cnt}");