// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количство строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array = NewArray(rows, columns, 1, 10);

PrintArray(array);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMean(array);

int[,] NewArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double res = 1;
        int a = columns;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res = res * arr[i, j];
        }
        res = res / a;
        Console.Write($"{Math.Round(res, 1)}; ");
    }
}