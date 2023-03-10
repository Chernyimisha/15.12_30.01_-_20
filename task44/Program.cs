// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество чисел Фибоначчи: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = GetFibonacciArray(num);
Console.Write($"N = {num} -> ");
PrintArray(array);

int[] GetFibonacciArray(int size)
{
    int[] fib = new int[size];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < fib.Length; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

