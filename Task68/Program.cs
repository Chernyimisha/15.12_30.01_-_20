// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = -1;
int n = 0;

int result = AkkermanFunc(m, n);

if (result > 0) Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {result}");
else Console.WriteLine("Дана некорректная пара чисел");

int AkkermanFunc(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num1 > 0 && num2 == 0) return AkkermanFunc(num1 - 1, 1);
    else if (num1 > 0 && num2 > 0) return AkkermanFunc(num1 - 1, AkkermanFunc(num1, num2 - 1));
    return 0;
}
