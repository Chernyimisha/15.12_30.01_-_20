// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] array2D = CreateMatrix(5, 5, -100, 100);
PrintMatrix(array2D);
Console.WriteLine();


if (array2D.GetLength(0) == array2D.GetLength(1))
{
    array2D = ReplacingRowsColumns(array2D);
}
else Console.WriteLine("Заменить строки на столбцы невозможно.");

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

int[,] ReplacingRowsColumns(int[,] matr)
{
    int[,] replacementMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            replacementMatr[i, j] = matr[j, i];
        }
    }
    return replacementMatr;
}

