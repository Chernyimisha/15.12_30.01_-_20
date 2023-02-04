// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumCount(number);
Console.WriteLine($"{number} -> {sum}");

int SumCount(int num)
{
    //int result = 0;

    // while (num > 0)
    // {
    //     result += num % 10;
    //     num /= 10;
    // }
    // return result;

    if (num == 0) return num;
    else return SumCount(num / 10) + num % 10;
}