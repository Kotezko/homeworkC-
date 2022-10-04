// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число b");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a % b == 0 && a / b == b)
{
    Console.WriteLine("a число является квадратом b");
}
else
{
    Console.WriteLine("число a не является квадратом числа b");
}
