// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,] array)
{
    int limit1 = 10;
    int limit2 = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (limit1 >= 99 && limit2 < -9)
                {
                    array[i, j, k] = limit2++;
                }
                if (limit1 >= 10 && limit1 < 100)
                {
                    array[i, j, k] = limit1++;
                }
            }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
                
            }
            Console.WriteLine();
        }
        
    }
}
int[,,] array = new int[5,6,6];
FillArray(array);
PrintArray(array);
