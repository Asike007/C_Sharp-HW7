// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количетсво строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количетсво столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите стороку искомого элемента: ");
int searchingRow = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите столбец искомого элемента: ");
int searchingColumn = int.Parse(Console.ReadLine()!);

int[,] array = NewArray(rows, columns, min, max);
PrintArray(array);
Searching(array);

int[,] NewArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
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

void Searching(int[,] arr)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == searchingRow && j == searchingColumn)
            {
                res = arr[searchingRow, searchingColumn];
                Console.Write($"Искоемое значение равно: {res} ");
                return;
            }
        }
    }
    Console.Write($"Такого числа в массиве нет");
}