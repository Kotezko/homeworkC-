// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("введите номер дня недели");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a > 0 && a < 8)
{
    if (a == 1)
    {
        Console.WriteLine("Monday - weekday");
    }
    else if (a == 2)
    {
        Console.WriteLine("Tuesday - weekday");
    }
    else if (a == 3)
    {
        Console.WriteLine("Wednesday - weekday");
    }
    else if (a == 4)
    {
        Console.WriteLine("Thursday - weekday");
    }
    else if (a == 5)
    {
        Console.WriteLine("Friday - weekday");
    }
    else if (a == 6)
    {
        Console.WriteLine("Saturday - weekend");
    }
    else if (a == 7)
    {
        Console.WriteLine("Sunday - weekend");
    }
}
else
{
    Console.WriteLine("не верный номер дня недели");
}


