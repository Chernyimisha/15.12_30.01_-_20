// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quantityDigit = QuantityDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {quantityDigit}");


int QuantityDigit(int num)
{
    int sum = 0;
    while (num != 0)
    {
       num = num/10;
       sum++;
    }
    return sum;
}