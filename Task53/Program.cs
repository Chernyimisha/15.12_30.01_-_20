// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] array2D = CreateMatrix(5, 8, -100, 100);
PrintMatrix(array2D);
ReplacingFirstLastRows (array2D);
Console.WriteLine();
PrintMatrix(array2D);

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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void ReplacingFirstLastRows (int[,] matr)
{
    int temp = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp = matr[0,j];
        matr[0,j] = matr[matr.GetLength(0)-1,j];
        matr[matr.GetLength(0)-1,j] = temp;
    }
}