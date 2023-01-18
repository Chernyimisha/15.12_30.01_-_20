int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
// int sumPositive = GetSumPositiveElem(array);
// int sumNegative = GetSumNegativeElem(array);

int[] sumPositiveNegative = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegative[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegative[1]}");

// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        else if (arr[i] < 0) sumNeg += arr[i];
    }
    return new[] { sumPos, sumNeg };
}

