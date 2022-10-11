// Найти кубы чисел от 1 до N


Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine() ?? "0");
int b = 1;

while (b <= N)
{
    double result = Math.Pow(b, 3);
    Console.WriteLine($"{b}^3 = {result}");
    b++;
}

//либо 
//while (b <= N)
//{
//  int result = b * b * b;
//  Console.WriteLine($"{b}^3 = {result}");
//  b++;
//}
