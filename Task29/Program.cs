// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.Write(" -> ");
Console.Write("[");
PrintArray(array);
Console.Write("]");

void FillArray(int[] collection)
{
    int length = collection.Length;
    Random rnd = new Random();
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    
    while (position < count-1)
    {
        Console.Write($"{col[position]},");
        position++;
    }

    Console.Write($"{col[count-1]}");
}