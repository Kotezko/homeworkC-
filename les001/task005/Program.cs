// Показать числа от -N до N

Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("получается такой числовой ряд:");
int b = (a * -1);
if (a > 0)
{
    while(b <= a)
    {
      Console.WriteLine(b);
      b++;
    }
}
else while(a <= b)
    {
      Console.WriteLine(a);
      a++;
    }