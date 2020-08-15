using System;

class Point
{
    int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        Point p2 = new Point(-1, 1);

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        string s = "Hello, Hello!";
        Console.WriteLine(s);
    }
}
