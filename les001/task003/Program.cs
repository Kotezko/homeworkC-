// Найти максимальное из трех чисел

Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите третье число");
int c = int.Parse(Console.ReadLine() ?? "0");
int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("максимальным из трех чисел явялется: " + max);