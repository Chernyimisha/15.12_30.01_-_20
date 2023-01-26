// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение для b1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для k1: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для b2: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для k2: ");
int d = Convert.ToInt32(Console.ReadLine());


double[] coordinate = CalcCoordinate(a, b, c, d);
Console.Write($"b1={a}, k1={b}, b2={c}, k2={d} -> ({coordinate[0]},{coordinate[1]})");

//PrintArray(coordinate);

double[] CalcCoordinate(int b1, int k1, int b2, int k2)
{
    double[] arr = new double[2];
    arr[0] = (double)(b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;
    return arr;
}

// void PrintArray(double[] arr)
// {
//     Console.Write("(");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.Write(")");
// }

