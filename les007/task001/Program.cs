// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void SortMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] >= array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
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
FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);