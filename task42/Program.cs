// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Вариант решения с помощью типа String///////////////////

// string СonvNumber(int number)
// {
//     string result = string.Empty;
//     while (number > 0)
//     {
//         result = number % 2 + result;
//         number = number / 2;
//     }
//     return result;
// }

// string res = СonvNumber(2);

// Console.WriteLine(res);

// Вариант решения с помощью типа Int//////////////////

Console.Write("Введите число для преобразования в двоичную систему исчисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int convertDecimalToBinary = ConvertDecimalToBinary(number);
Console.WriteLine(convertDecimalToBinary);

int ConvertDecimalToBinary(int num)
{
    int result = 0;
    int multiplyer = 1;

    while (num != 0)
    {
        result = result + num % 2 * multiplyer;
        num = num / 2;
        multiplyer *= 10;
    }
    return result;
}