
void REF(ref double x,ref double y) 
{
    double z;
    z = x;
    x = y; 
    y = z;
}
Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y = Convert.ToDouble(Console.ReadLine());
REF(ref x,ref y);
Console.Write("x = " + x);
Console.WriteLine();
Console.Write("y = " + y);

