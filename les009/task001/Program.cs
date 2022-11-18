// Показать натуральные числа от M до N, N и M заданы


Console.WriteLine("enter M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter N");
int N = Convert.ToInt32(Console.ReadLine());


void PrintNum(int n, int m)
{
    if (n < m) return;
    PrintNum(n - 1, m);
    Console.Write($"{n} ");
}
if (M < N)
    PrintNum(N, M);
else
    PrintNum(M, N);

