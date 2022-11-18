// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void SummChis(int a, int b, int n, int count)
{
    if (n <= count)
    {
        int sum = a + b;
        Console.Write($"{sum} ");
        SummChis(b,sum,n+1,count);
    }
}

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество чисел для показа: ");
int count = int.Parse(Console.ReadLine() ?? "0");
SummChis(A, B, 1, count);