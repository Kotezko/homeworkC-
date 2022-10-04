// Выяснить является ли число чётным

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num % 2 == 0)
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число нечетное");
}
