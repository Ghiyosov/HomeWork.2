void EvenCount(int n) 
{
    int cnt=0;
    for (int i = n; i > 0; i /= 10)
    {
        if ((i%10) % 2 == 0) 
        {
            cnt++;
        }
    }
    Console.WriteLine("Even => "+cnt);
}

EvenCount(1234567);

void OddCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if ((i % 10) % 2 != 0)
        {
            cnt++;
        }
    }
    Console.WriteLine("Odd => " + cnt);
}

OddCount(1234567);

void DigitCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i /= 10)
    {
        cnt++;
    }
    Console.WriteLine("Digit => " + cnt);
}

DigitCount(1234567);

void SumDigit(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i /= 10)
    {
        cnt+=i%10;
    }
    Console.WriteLine("Sum => " + cnt);
}

SumDigit(1234567);