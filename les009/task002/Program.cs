// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("enter M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter N");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int n, int m)
{
    if (n==m) return m;
    else return n + Sum(n-1,m);
}
if (M < N) Console.WriteLine(Sum(N,M));
else Console.WriteLine(Sum(M,N));