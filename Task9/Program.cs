void MinNumber(int a, int b) 
{
    if (a > b) Console.WriteLine(b);
    else if (b > a) Console.WriteLine(a);
    else Console.WriteLine(a);
} 


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

MinNumber(a, b);