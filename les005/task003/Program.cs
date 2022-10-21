// Написать программу копирования массива

void FillArray(int[] array,int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
     var random = new Random();
     array[i] = random.Next(min, max);   
    }
}
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
int[] CopyArray(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}
int[] array = new int[10];
FillArray(array, -10, 10);
Console.WriteLine("array:");
PrintArray(array);
int[] arr = CopyArray(array);
Console.WriteLine("arr - copy of array:");
PrintArray(arr);