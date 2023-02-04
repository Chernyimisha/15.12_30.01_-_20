// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) Console.WriteLine("Введены некорректные числа.");
else if (m < n) Console.WriteLine($"M = {m}; N = {n} -> {SumNaturalNumbers(m, n)}");
else if (m > n) Console.WriteLine($"M = {m}; N = {n} -> {SumNaturalNumbers(n, m)}");

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num2; //или num1 без разницы, т.к. они одинаковы на этом витке.
    return num2 + SumNaturalNumbers(num1, num2 - 1);
}

