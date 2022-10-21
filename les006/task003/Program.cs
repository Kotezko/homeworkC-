// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillMatrix(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            var random = new Random();
            array[i, j] = random.Next(min, max);
        }
    }
}
void PrintMatrix(int[,] array)
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
void FindAndSqElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    array[i, j] = (int)Math.Pow(array[i, j], 2);
                }
            }
        }
    }
}

Console.WriteLine("введите m:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите m:");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillMatrix(matrix, 2, 3);
Console.WriteLine("matrix:");
PrintMatrix(matrix);
FindAndSqElement(matrix);
Console.WriteLine("matrix after:");
PrintMatrix(matrix);