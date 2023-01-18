// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите число А: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите натуральное число B: ");
int degree = Convert.ToInt32(Console.ReadLine());
int power = 0;
Console.WriteLine ();

if (degree>0)
{
    power = Pow (digit, degree);
    Console.WriteLine ($"{digit}, {degree} -> {power}");
}
else Console.WriteLine ("Введено некорректное число В");

int Pow (int A, int B)
{
    int result = A;
    for(int i=1; i<B;i++)
    {
        result = result*A;
    }
    return result;
}