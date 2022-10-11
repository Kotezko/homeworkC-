// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[] { 0, 1, 0, 1, 0, 1, 0, 1 };
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

Console.Write("array: ");
PrintArray(array);
Console.WriteLine();

int[] arr = new int[8];
FillArray(arr, 0, 2);
Console.Write("arr: ");
PrintArray(arr);