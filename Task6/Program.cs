﻿void Divisors(int a) 
{
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0)
        {
            Console.Write(i+" ");
        }  
    }
}
Divisors(16);