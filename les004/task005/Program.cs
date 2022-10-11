// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int SumEvenPosNums(int[] array)
{
    int sum = 0;
    int pos = 0;
    foreach (int element in array)
    {
        if (pos % 2 == 0)
        {
            sum += array[pos];
        }
        pos++;
    }
    return sum;
}
int[] array = new int[10];
FillArray(array, 0, 5);
Console.Write("array: ");
PrintArray(array);
Console.Write($"Сумма чисел стоящих на четной позиции = {SumEvenPosNums(array)}");
