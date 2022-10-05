// Задать номер четверти, показать диапазон для возможных координат

Console.WriteLine("введите четверть для которой необходисо указать диапазон");
int x = int.Parse(Console.ReadLine() ?? "0");

if (x > 0 && x < 5)
{
    if (x == 1)
    {
        Console.WriteLine("диапазон 1 четверти x>0 и y>0");
    }
    else if (x == 2)
    {
        Console.WriteLine("диапазон 2 четверти x<0 и y>0");
    }
    else if (x == 3)
    {
        Console.WriteLine("диапазон 3 четверти x<0 и y<0");
    }
    else if (x == 4)
    {
        Console.WriteLine("диапазон 4 четверти x>0 и y<0");
    }
}
else
{
    Console.WriteLine("не верный номер четверти");
}


