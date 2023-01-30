// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите количество строк нового массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов нового массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}");
int[,] matrix = CreatePrintMatrix(m, n);

int[,] CreatePrintMatrix(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],2}, ");
            else Console.Write($"{arr[i, j],2}");
        }
        Console.WriteLine("]");
    }
    return arr;
}


