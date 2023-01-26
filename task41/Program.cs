// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayEnterInt(m);

int sum = CountPositiveNumbers(array);

PrintArray(array);
Console.WriteLine($" -> {sum}");

int[] CreateArrayEnterInt(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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
    Console.Write("]");
}

int CountPositiveNumbers(int[] arr)
{
    int result=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) result++;
    }
    return result;
}

