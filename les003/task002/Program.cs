// Подсчитать сумму цифр в числе

Console.WriteLine("enter the number");
int num = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
num = Math.Abs(num);

while (num > 0)
{
    sum += num % 10;
    num = num / 10;
}
Console.WriteLine($"result = {sum}");