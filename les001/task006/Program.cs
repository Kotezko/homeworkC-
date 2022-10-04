// Показать четные числа от 1 до N

Console.WriteLine("введите любое число больше 1");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("получается такой числовой ряд:");
int b = 1;

if (a > 1)
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