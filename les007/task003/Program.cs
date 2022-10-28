// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
int[] SumStringMatrix(int[,] array)
{
    int[] newarray = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newarray[i] = sum;
        sum = 0;

    }
    return newarray;
}
int FindMinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            minIndex = i;

    }
    return minIndex;
}
int[,] matrix = new int[5, 4];
FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);
int[] sum = SumStringMatrix(matrix);
Console.WriteLine("Сумма строк матрицы:");
PrintArray(sum);
Console.WriteLine($"Строка с минимальной суммой: {FindMinIndex(sum)}");


