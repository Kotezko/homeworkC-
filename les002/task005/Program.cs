// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("введите 2 если 2D, введите 3 если 3D");
int x = int.Parse(Console.ReadLine() ?? "0");

if (x == 2)
{
    Console.WriteLine("введите X1");
    double X1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите X2");
    double X2 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите Y1");
    double Y1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите Y2");
    double Y2 = double.Parse(Console.ReadLine() ?? "0");
    double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
    Console.WriteLine("расстояние между точками в пространстве 2D: " + result);
}
else if (x == 3)
{
    Console.WriteLine("введите X1");
    double X1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите X2");
    double X2 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите Y1");
    double Y1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите Y2");
    double Y2 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите Z1");
    double Z1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("введите Z2");
    double Z2 = double.Parse(Console.ReadLine() ?? "0");
    double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
    Console.WriteLine("расстояние между точками в пространстве 3D: " + result);
}
else
{
    Console.WriteLine("неверные данные");
}