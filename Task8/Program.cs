void MinNumber(int a, int b, int c, int d) 
{
    int z = 2147483647;
    if (a < z) z = a;
    if (b < z) z = b;
    if (c < z) z = c;
    if (d < z) z = d;
    Console.WriteLine(z);
} 


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int  c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
MinNumber(a, b, c, d);