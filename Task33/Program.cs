Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве: ");
int maxArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве: ");
int minArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задайте искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string answer = Number(number, array) == false ? "Нет" : "Да";
Console.WriteLine();
Console.Write($"{number}; ");
PrintArray(array);
Console.Write($"-> {answer}; ");

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
    Console.Write("]");
}

bool Number(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}