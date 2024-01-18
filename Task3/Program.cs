int MinDigit(int n) 
{
    int min = 2147483647;
    for (int i = n; i>0; i /= 10) 
    {
        if (i % 10 < min) min = i % 10;
    }
    return min;
}
Console.WriteLine(MinDigit(12345));

int MaxDigit(int n)
{
    int max = -2147483648;
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 > max) max = i % 10;
    }
    return max;
}
Console.WriteLine(MaxDigit(12345));

void SumMaxMin(int n)
{
    int sum = 0;
    sum=MinDigit(n) + MaxDigit(n);

    Console.WriteLine($"{MinDigit(n)} + {MaxDigit(n)} = {sum} ");
}

SumMaxMin(12345);
