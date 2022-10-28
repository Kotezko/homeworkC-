// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

int[,]? ChangeMatrix(int[,] array)
{
    int[,] newmatrix = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newmatrix[i, j] = array[j, i];
            }
        }
        return newmatrix;
    }
    else return null;
}
Console.WriteLine("введите m:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите m:");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);
int[,]? newmatrix = ChangeMatrix(matrix);
if (newmatrix != null)
{
    Console.WriteLine("Матрица после замены:");
    PrintMatrix(newmatrix);
}
else
{
    Console.WriteLine("Замена не получилась, матрица не квадратная");
}