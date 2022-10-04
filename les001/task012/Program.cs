// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
else 
{
    Console.WriteLine("в этом числе нету третьей цифры");
}
