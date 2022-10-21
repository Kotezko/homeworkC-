// Показать двумерный массив размером m×n заполненный вещественными числами

void FillMatrix(double[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            var random = new Random();
            array[i, j] = random.NextDouble() * random.Next(min, max);
        }
    }
}
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("введите m:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите m:");
int n = int.Parse(Console.ReadLine() ?? "0");
double[,] matrix = new double[m, n];
FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);