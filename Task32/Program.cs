int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.Write(" -> ");
Revers (array);
PrintArray(array);

void FillArray(int[] collection)
{
    int length = collection.Length;
    Random rnd = new Random();
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-10, 11);
    }
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

void Revers (int[] arr)
{
    for(int i=0; i<arr.Length;i++)
    {
        arr[i]*=-1;
    }
}
