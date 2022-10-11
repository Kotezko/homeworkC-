// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

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
int ArraySum(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        sum += element;
    }
    return sum;
}

int[] array = new int[12];
FillArray(array, 0, 9);
Console.Write("array: ");
PrintArray(array);
Console.Write($"sum = {ArraySum(array)}");
