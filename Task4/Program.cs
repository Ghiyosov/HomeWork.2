
double Pow(double x, double y) 
{
    double z;  
    z = Math.Pow(x, y);
    return z;
}
Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Pow(x,y));

