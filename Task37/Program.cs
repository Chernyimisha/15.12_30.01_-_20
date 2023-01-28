// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и послений элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateNewArray(size);
int[] nextArray = CompositionСoupleDigits(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write(" -> ");
PrintArray(nextArray);

int[] CreateNewArray(int num)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 10);
    }
    return arr;
}

int[] CompositionСoupleDigits(int[] arr)
{
    int sizeNewArray = 0;
    if (arr.Length%2==0) sizeNewArray = arr.Length/2;
    else sizeNewArray = arr.Length/2 + 1;
    
    
    int[] newArray = new int[sizeNewArray];
    
    for (int i = 0; i < sizeNewArray-1; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length-1-i];
    }
    if (arr.Length%2!=0) newArray[newArray.Length-1] = arr [arr.Length/2];
    else newArray[newArray.Length-1] = arr [arr.Length/2]*arr [arr.Length/2-1];
    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}