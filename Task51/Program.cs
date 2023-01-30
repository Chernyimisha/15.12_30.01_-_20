// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] matrix = CreateMatrix(15, 15, -10, 10);
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);
Console.WriteLine();
int sumElementsMainDiagonal = SumElementsMainDiagonal (matrix);
Console.Write("Сумма элементов главной диагонали: ");
PrintSumElements(matrix);
Console.WriteLine($" = {sumElementsMainDiagonal}");

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

void PrintSumElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j && j < matr.GetLength(1)-1) Console.Write(matr[i, j] + ", ");
            else if (i == j) Console.Write(matr[i, j]);
        }
    }
}

int SumElementsMainDiagonal (int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) result = result + arr[i,j];
        }
    }
    return result;
}
