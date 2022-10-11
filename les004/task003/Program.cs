// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        var random = new Random();
        array[i] = random.Next(min, max);
    }
}
int ArrayCountOddNums(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 != 0)
        {
            count++;
        }
    }
    return count;
}
int ArrayCountEvenNums(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[10];
FillArray(array, 100, 1000);
Console.Write("array: ");
PrintArray(array);
Console.Write($"в массиве {ArrayCountEvenNums(array)} четных и {ArrayCountOddNums(array)} нечетных");

