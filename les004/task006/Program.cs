// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


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
Console.WriteLine("задайте длинну массива");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
FillArray(array, 1, 5);
Console.Write("array: ");
PrintArray(array);
Console.WriteLine();

if (array.Length < 2) Console.WriteLine("Result = пар элементов не найденно в заданном массиве");
else
{
    int posMin = 0;
    int posMax = array.Length - 1;
    int mid = array.Length / 2;
    if (array.Length % 2 == 0)
        while (posMin <= mid && posMax >= mid)
        {
            int result = array[posMin] * array[posMax];
            Console.WriteLine($"произведение пар чисел на позициях {posMin} и {posMax} = {result}");
            posMin++;
            posMax--;
        }
    else while (posMin < mid && posMax > mid)
        {
            int result = array[posMin] * array[posMax];
            Console.WriteLine($"произведение пар чисел на позициях {posMin} и {posMax} = {result}");
            posMin++;
            posMax--;
        }
}


