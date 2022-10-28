// Найти произведение двух матриц

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
int[,]? DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    matrix3[i, j] += (matrix1[i, k]) * (matrix2[k, j]);
                }
            }
        }
        return matrix3;
    }
    else return null;
}
Console.Write("Введите количество строк 1-й матрицы: ");
int n1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов 1-й матрицы: ");
int m1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество строк 2-й матрицы: ");
int n2 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов 2-й матрицы: ");
int m2 = int.Parse(Console.ReadLine()??"0");
int[,] matrix1 = new int[n1, m1];
int[,] matrix2 = new int[n2, m2];
FillMatrix(matrix1, 1, 3);
FillMatrix(matrix2, 1, 3);
Console.WriteLine("matrix1:");
PrintMatrix(matrix1);
Console.WriteLine("matrix2:");
PrintMatrix(matrix2);
int[,]? matrix3 = DivMatrix(matrix1, matrix2);
if (matrix3 != null)
{
    Console.WriteLine("Результат умножения:");
    PrintMatrix(matrix3);
}
else
    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

