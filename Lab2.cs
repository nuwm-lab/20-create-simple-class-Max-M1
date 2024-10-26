using System;

public class Line
{
    private double a;
    private double b;
    private double c;
    private double x1, y1;
    private double x2, y2;

    public Line()
    {
        a = 0;
        b = 0;
        c = 0;
        x1 = 0;
        y1 = 0;
        x2 = 0;
        y2 = 0;
    }

    public double A
    {
        get { return a; }
        set { a = value; }
    }

    public double B
    {
        get { return b; }
        set { b = value; }
    }

    public double C
    {
        get { return c; }
        set { c = value; }
    }

    public double X1
    {
        get { return x1; }
        set { x1 = value; }
    }

    public double Y1
    {
        get { return y1; }
        set { y1 = value; }
    }

    public double X2
    {
        get { return x2; }
        set { x2 = value; }
    }

    public double Y2
    {
        get { return y2; }
        set { y2 = value; }
    }

    public bool IsPointOnLine(double x, double y)
    {
        return A * x + B * y + C == 0;
    }

    public void InputData()
    {
        Console.WriteLine("Введiть коефiцiєнти прямої (a, b, c):");
        Console.Write("a = ");
        A = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        B = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        C = double.Parse(Console.ReadLine());

        Console.WriteLine("\nВведiть координати першої точки (x1, y1):");
        Console.Write("x1 = ");
        X1 = double.Parse(Console.ReadLine());

        Console.Write("y1 = ");
        Y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nВведiть координати другої точки (x2, y2):");
        Console.Write("x2 = ");
        X2 = double.Parse(Console.ReadLine());

        Console.Write("y2 = ");
        Y2 = double.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main()
    {
        Line line = new Line();

        line.InputData();

        Console.WriteLine($"\nРiвняння: {line.A}x + {line.B}y + {line.C} = 0");

        if (line.IsPointOnLine(line.X1, line.Y1))
        {
            Console.WriteLine($"\nТочка ({line.X1}, {line.Y1}) належить прямiй.");
        }
        else
        {
            Console.WriteLine($"\nТочка ({line.X1}, {line.Y1}) не належить прямiй.");
        }

        if (line.IsPointOnLine(line.X2, line.Y2))
        {
            Console.WriteLine($"Точка ({line.X2}, {line.Y2}) належить прямiй.");
        }
        else
        {
            Console.WriteLine($"Точка ({line.X2}, {line.Y2}) не належить прямiй.");
        }
    }
}