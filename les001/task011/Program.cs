// Выяснить, кратно ли число заданному, если нет, вывести остаток. 

Console.WriteLine("ведите число которое нужно поделить");
int numA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("ведите число на которое нужно поделить");
int numB = int.Parse(Console.ReadLine() ?? "0");

if (numA % numB == 0)
{
    Console.WriteLine("число " + numA + " кратно числу " + numB);
}
else 
{
    Console.WriteLine("число " + numA + " не кратно числу " + numB + ", остаток после деления: " + numA % numB);
}