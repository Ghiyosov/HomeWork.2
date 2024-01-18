void MaxNumber(int a, int b) 
{
    if (a > b) Console.WriteLine(a);
    else if (b > a) Console.WriteLine(b);
    else Console.WriteLine(a);
} 


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

MaxNumber(a, b);