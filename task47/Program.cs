﻿// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] arr = NewArray(rows, columns, -10.0, 10.0);
PrintArray(arr);

double[,] NewArray(int m, int n, double minValue, double maxValue)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().NextDouble() * 10;
        }
    }
    return res;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}