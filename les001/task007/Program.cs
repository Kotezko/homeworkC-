// Показать последнюю цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
int num = int.Parse(Console.ReadLine() ?? "0");

int result = num % 10;

Console.WriteLine("последняя цифра числа: " + result);