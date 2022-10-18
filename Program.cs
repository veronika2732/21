// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
Console.Clear();

double Disk(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2)+ MathPow(y2 - y1, 2)+Math.Pow(z2 - z1, 2));

    return.result;
}

Console.Write("Введите Х координаты точки А:");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки А:");
int ay = int.Parse(Console.Readline()!);

Console.Write("Введите Z координаты точки А:");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите х координаты точки В:");
int bx = int.Parse(Console.Readline()!);

Console.Write("Введите Y координаты точки В:");
int by = int.Parse(Console.ReadLine()!);
