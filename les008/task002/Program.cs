// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

(int val1, int val2, int val3) Poisk(int[,] array)
{
    int min = 1;
    var result = (val1: 0, val2: 0, val3: 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                result.val1 = i;
                result.val2 = j;
                result.val3 = array[i, j];
            }
        }
    }
    return result;
}
int [,] ChangeMatrix(int[,] array, int Line, int Column)
{ int[,] res = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i,j] = array[i,j];
            if (i>=Line && j>=Column)
            {
                res[i,j]=array[i+1,j+1];
            }
            else if (i>=Line)
            {
                res[i,j]=array[i+1,j];
            }
            else if (j>=Column)
            {
                res[i,j]=array[i,j+1];
            }
        }
    }
    return res;
}
Console.WriteLine("введите m:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите m:");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);
var result = Poisk(matrix);
Console.WriteLine($"Минимальный элемент: {result.val3} на строке: {(result.val1)+1}, и столбце: {(result.val2)+1}.");
int[,] newMatrix = ChangeMatrix(matrix,result.val1,result.val2);
PrintMatrix(newMatrix);