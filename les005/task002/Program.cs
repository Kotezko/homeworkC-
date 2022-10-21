// Написать программу масштабирования фигуры

double[] Scaling (string[] array, double k)
{
    double[] coord = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        coord[i] = Convert.ToDouble(array[i]) *k;
    }
    return coord;
}

void PrintArray(double []array)
{
    for (int i = 0; i < array.Length; i+=2)
    {
        Console.Write($"({array[i]}, {array[i+1]})");
    }
}
Console.Write("Введите координаты точек фигуры через запятую ',': ");
string[] figure = (Console.ReadLine() ?? "0").Split(',');
Console.Write("Введите коэфициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");
double[] ScaledFigure = Scaling(figure, k);
PrintArray(ScaledFigure);