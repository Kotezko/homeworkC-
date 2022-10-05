// Программа проверяет пятизначное число на палиндром

Console.WriteLine("введите пятизначное число");
string num = Console.ReadLine() ?? "0";

if (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("число " + num + " является полиндромом");
    }
    else
    {
    Console.WriteLine("число " + num + " не является полиндромом");
    }
}
else
{
Console.WriteLine("неверное число");
}

