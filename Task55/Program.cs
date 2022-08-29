// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateIntMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы- col
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

void ChangRowAndCol(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1 + i; j < matrix.GetLength(0); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] mtrx = CreateIntMatrix(4, 4, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

if (mtrx.GetLength(0) == mtrx.GetLength(1))
{
    ChangRowAndCol(mtrx);
    PrintMatrix(mtrx);
}
else Console.WriteLine("Поменять строки со столбцами в этой матрице невозможно!");
