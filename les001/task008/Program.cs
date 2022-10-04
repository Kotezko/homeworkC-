// Показать вторую цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
int num = int.Parse(Console.ReadLine() ?? "0");

int div1 = num / 10;
int result = div1 % 10;

Console.WriteLine("вторая цифра числа: " + result);