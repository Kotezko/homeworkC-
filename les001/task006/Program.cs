// Показать четные числа от 1 до N

Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("получается такой числовой ряд:");
int b = 1;

if (a > 0)
{
    while (b <= a)
    {
        if (b % 2 == 0)
        {
            Console.WriteLine(b);
            b++;
        }
        else
        {
            b++;
        }
    }
}
else
{
    Console.WriteLine("неверное число");
}