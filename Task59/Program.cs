// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] array2D = CreateMatrix(5, 8, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int min = MinElemCount(array2D);
Console.WriteLine(min);
Console.WriteLine();
int[] firstMinElementCoordinate = FirstMinElementCoordinate(array2D);
PrintArray(firstMinElementCoordinate);
Console.WriteLine();
int[,] newMatrix = FillNewMatrix(array2D);
PrintMatrix(newMatrix);

int[,] FillNewMatrix(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != firstMinElementCoordinate[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != firstMinElementCoordinate[1])
                {
                    result[k, l] = matrix[i, j];
                    l++;
                }
            }
        l = 0;
        k++;
        }
        // l = 0;
        // k++;
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i]);
    }
}

int[] FirstMinElementCoordinate(int[,] matrix)
{
    int[] result = new int[2];
    int i = 0;
    int j = 0;
    while (i < matrix.GetLength(0))
    {
        while (j < matrix.GetLength(1))
        {
            if (matrix[i, j] != min) j++;
            else
            {
                result[0] = i;
                result[1] = j;
                break;
            }
        }
        if (result[0] == 0 && result[1] == 0)
        {
            j = 0;
            i++;
        }
        else break;
    }
    return result;
}

int MinElemCount(int[,] matrix)
{
    int result = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < result) result = matrix[i, j];
        }
    }
    return result;
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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],1}, ");
            else Console.Write($"{matr[i, j],1}");
        }
        Console.WriteLine("]");
    }
}



