// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("любое число от 10 до 99");
int num = int.Parse(Console.ReadLine() ?? "0");

int div1 = num / 10;
int div2 = num % 10;
int result = div1;

if (div1 < div2)
{
    result = div2;
}

Console.WriteLine("наибольшая цифра числа: " + result);