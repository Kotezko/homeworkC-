// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("enter the number");
int num = int.Parse(Console.ReadLine() ?? "0");
int result = 1;
num = Math.Abs(num);

for (int i = 1; i <= num; i++)
{
    result *= i;
}
Console.WriteLine($"result = {result}");