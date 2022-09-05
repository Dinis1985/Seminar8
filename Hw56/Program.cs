// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateIntMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(j < matrix.GetLength(1) - 1 ?
            $"{matrix[i, j],4}," : $"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void MinSumRow(int[,] matrix)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов: {minSum + 1} строка");
}

int[,] mtrx = CreateIntMatrix(4, 4, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

MinSumRow(mtrx);


