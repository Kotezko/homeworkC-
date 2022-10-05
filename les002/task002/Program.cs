// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число b");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a % b == 0 && a / b == b)
{
    Console.WriteLine("число a является квадратом b");
}
else if (b % a == 0 && b / a == a)
{
    Console.WriteLine("число b является квадратом a");
}

else
{
    Console.WriteLine("ни одно из заданных чисел не является квадратом другого");
}