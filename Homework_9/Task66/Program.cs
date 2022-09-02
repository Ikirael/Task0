/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int RecSum(int M, int N, int sum)
{
    if(sum < N)
    sum += RecSum(M,N,sum+1);

    return sum;
}

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int a;
if(N < M)
{
    a = N;
    N = M;
    M = a;
}
Console.WriteLine(RecSum(M,N,M+1));