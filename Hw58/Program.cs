// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[row, col];
int[,] secondMatrix = new int[row, col];
int[,] resultMatrix = new int[row, col];

if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Ошибка (количество строк не равно количеству столбцов)!!!");
    return;
}

void ResultIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    Console.WriteLine("Произведение двух матриц:");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void CreateIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(j < matrix.GetLength(1) - 1 ?
            $"{matrix[i, j],1}," : $"{matrix[i, j],1}");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine("Первая матрица:");
CreateIntMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
CreateIntMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();

ResultIntMatrix(matrix);
PrintMatrix(resultMatrix);
Console.WriteLine();