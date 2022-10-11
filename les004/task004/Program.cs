// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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

int[] array = new int[123];
FillArray(array, 0, 1000);
Console.Write("array: ");
PrintArray(array);
int count = 0;
foreach (int element in array)
{
    int min = 9;
    int max = 100;
    if (element > min && element < max)
    {
        count++;
    }
}
Console.WriteLine($"количество элементов массива из отрезка [10,99] = {count}");