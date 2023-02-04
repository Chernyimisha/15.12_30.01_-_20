// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
//  1 4 49 2
//  5 9 2 3
// 64 4 4 4

int[,] firstMatrix = CreateMatrix(3, 4, -10, 10);
Console.WriteLine("Изначально матрица выглядит вот так:");
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Новая матрица будет выглядеть вот так:");
int[,] secondMatrix = MatrixTransformation(firstMatrix);
PrintMatrix(secondMatrix);

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

int[,] MatrixTransformation(int[,] arr)
{
    int[,] secondArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0) secondArr[i, j] = arr[i, j] * arr[i, j];
            else secondArr[i, j] = arr[i, j];
        }
    }
    return secondArr;
}