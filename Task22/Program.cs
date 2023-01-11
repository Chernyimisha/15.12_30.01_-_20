Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (number > 0) PrintSquares(number);
else Console.WriteLine("Введены некорректные данные");

void PrintSquares(int n)
{
    for (int count = 1; count <= n; count++)
    {
        Console.WriteLine($"{count,4} {count * count,4}");
    }
}




