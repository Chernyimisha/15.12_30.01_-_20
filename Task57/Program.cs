// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] array2D = CreateMatrix(50, 10, 0, 10);
PrintMatrix(array2D);
int[] array = ConvertMatrixInArray(array2D);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
FillFrequencyArray(array);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i]);
    }
}

void FillFrequencyArray(int[] array)
{
    int result = 0;
    int arrayElement = 0;
    int index = 0;

    while (index < array.Length)
    {
        if (array[index] == arrayElement)
        {
            result++;
            index++;
        }
        else
        {
            if (result != 0) Console.WriteLine($"{arrayElement} встречается {result} раз");
            arrayElement++;
            result = 0;
        }
    }
    Console.WriteLine($"{arrayElement} встречается {result} раз");
}

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

int[] ConvertMatrixInArray(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0) * matr.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[index] = matr[i, j];
            index++;
        }
    }
    return arr;
}

