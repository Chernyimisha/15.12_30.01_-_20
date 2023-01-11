/*11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98*/

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число равно {number}");

int NewNumber (int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int newNum = firstDigit * 10 + secondDigit;
    return newNum;
}
int newNumber = NewNumber (number);
Console.WriteLine($"Искомое число =>{newNumber}");

/*int firstDigit = number / 100;
int secondDigit = number % 10;
int newNumber = firstDigit * 10 + secondDigit;

Console.WriteLine($"Искомое число =>{newNumber}");*/


