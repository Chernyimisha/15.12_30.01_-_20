// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] collection)
{
    int length = collection.Length;
    Random rnd = new Random();
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("{");
    while (position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write("}");
}

// int[] array = new int[8]; // 0,1,2,3,4,5,6,7

//             FillArray(array);
//             PrintArray(array);

//             void FillArray(int[] arr)
//             {
//                 Random rnd = new Random();
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     arr[i] = rnd.Next(0, 2);
//                 }
//             }

//             void PrintArray(int[] arr)
//             {
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     Console.Write(arr[i] + " ");
//                 }
//             }
