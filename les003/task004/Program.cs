// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine() ?? "0");
int b = 1;

while (b <= N)
{
    double result = Math.Pow(b, 3);
    int check = Convert.ToInt32(result) % 10;
    if (check % 2 == 0)
    {
        Console.WriteLine($"{b}^3 = {result}");
    }
    b++;
}

//либо

//while (b <= N)
//{
//    double result = Math.Pow(b, 3);
//    if (Convert.ToInt32(result) % 2 == 0)
//    {
//        Console.WriteLine($"{b}^3 = {result}");
//    }
//    b++;
//}

//либо

//while (b <= N)
//{
//  int result = b * b * b;
//  int check = result % 10;
//  if (check % 2 == 0)
//  {
//      Console.WriteLine($"{b}^3 = {result}");
//  }
//  b++;
//}

//либо

//while (b <= N)
//{
//  int result = b * b * b;
//  if (result % 2 == 0)
//  {
//      Console.WriteLine($"{b}^3 = {result}");
//  }
//  b++;
//}