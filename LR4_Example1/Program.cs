using System;
public class Triangle
{
    protected double a;
    protected double b;
    protected double c;
    public Triangle() { }
    public Triangle(double a, double b, double c)
    {
        this.a = a; this.b = b; this.c = c;
    }
    public void Print()
    {
        Console.WriteLine("a={0} b={1} c={2}", a,b,c);
    }
    public double Perimeter()
    {
        double p = a + b + c; return p;
    }
}
public class Equilateral : Triangle
{
    public Equilateral() { }
    public Equilateral(double x)
    {
        this.a=x; this.b=x; this.c=x;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random(); double p = 0;
        for (int i=1;i<=3;i++)
        {
            double x = rnd.Next(1, 5); double y = rnd.Next(1, 5); double z = rnd.Next(1, 5);
            //трикутник рівносторонній
            if (x == y && x == z)
            {
                //створюємо об'єкт дочірнього класу
                Equilateral t=new Equilateral(x);
                //викликаємо наслідуючі методи батьківського класу
                t.Print(); p = t.Perimeter();
            }
            else
            {
                //створюємо об'єкт батьківського класу
                Triangle t = new Triangle(x,y,z);
                t.Print(); p = t.Perimeter();
            }
            Console.WriteLine("P={0}", p);
        }
        Console.ReadKey();
    }
}