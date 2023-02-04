// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число 1: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число 2: ");
int digree = Convert.ToInt32(Console.ReadLine());
//int result = MathPow(number, digree);
//Console.WriteLine($"A = {number}; B = {digree} -> {result}");

if(digree>=0) Console.WriteLine($"A = {number}; B = {digree} -> {MathPow(number, digree)}");
else Console.WriteLine("Введена некорректная степень");

int MathPow(int num, int dig)
{
    if (dig == 0) return 1;
    else
    {
        return num * MathPow(num, dig - 1);
    }
}

