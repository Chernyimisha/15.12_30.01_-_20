// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle (a,b,c);
Console.WriteLine(result?"Треугольник существовать может":"Треугольник существовать не может");

bool IsExistTriangle (int num1, int num2, int num3)
{
    if (num1>num2+num3) return false;
    else if (num2>num1+num3) return false;
    else if (num3>num2+num1) return false;
    else return true;
}

// if (IsExistTriangle (a, b, c) == false) Console.WriteLine("Треугольник существовать не может");
// else Console.WriteLine("Треугольник существовать может");