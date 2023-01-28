// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("Задайте количество элементов нового массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(number);
PrintArray(array);
Console.WriteLine();
int[] copyArray = CreateCopyArray(array);
PrintArray(copyArray);
int[] CreateArray(int num)
{
    int[] arr = new int[num];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
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

int[] CreateCopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}