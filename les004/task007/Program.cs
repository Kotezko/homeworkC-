// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void PrintArray(double[] array)
{
    foreach (double element in array)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}

double[] array = new double[6] { 1.0, 1.5, 2.7, 4.3, 2.2, 5.1 };

Console.Write("array: ");
PrintArray(array);
Console.WriteLine();
if (array.Length < 2) Console.WriteLine("Result = 0");
else
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Min = {min} Max = {max}");
    Console.WriteLine($"Result = {max - min}");
}
