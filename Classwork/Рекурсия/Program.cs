
int sum = 0;
void REC(int num)
{
    if (num == 0) return;
    else
    {
    sum += num%10;  
    Console.WriteLine(sum);   
    REC(num/10);
    }
}

REC(559);
Console.WriteLine(sum);