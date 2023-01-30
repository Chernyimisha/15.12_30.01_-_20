// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

//int[,] matrix = new int[3, 4];
// Console.WriteLine($"m = {matrix.GetLength(0)}, n = {matrix.GetLength(1)}");
// CreateMatrix(matrix);
// PrintMatrix(matrix);

// void CreateMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(-100, 100);
//         }
//     }
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

int [,] array2D = CreateMatrix(5, 8, -100, 100);
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
            if (j<matr.GetLength(1)-1) Console.Write($"{matr[i, j], 3}, ");
            else Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

