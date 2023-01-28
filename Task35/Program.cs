// Задача 35. Найдите количество элементов массива из 123 элементов, значение которых лежат
// в отрезке [10,99].
// Пример: [массив]-> 1

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());


if (CheckMinMax(min, max))
{
    int[] array = CreateNewArray(size);
    PrintArray(array);
    int quantityСertainDigitals = SegmentSearch(array, min, max);
    Console.WriteLine($" -> {quantityСertainDigitals}");
}
else Console.WriteLine("Введены некорректные значения min и max элементов массива");

bool CheckMinMax(int Mn, int Mx)
{
    return Mn < Mx;
}

int SegmentSearch(int[] arr, int min, int max)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) result++;
    }
    return result;
}

int[] CreateNewArray(int num)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 200);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}