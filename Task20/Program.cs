/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1), -> 15.84
A (7,-5); B (1,-1) -> 11.53*/

int[] pointA = new int[2];
int[] pointB = new int[2];

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
pointA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
pointA[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
pointB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
pointB[1] = Convert.ToInt32(Console.ReadLine());

Console.Write($"({pointA[0]},{pointA[1]})");
Console.Write($"({pointB[0]},{pointB[1]})");

double distance = Distance(pointA[0], pointA[1],
                            pointB[0], pointB[1]);

Console.Write($" ->{distance}");

double Distance(int x1, int y1,
                 int x2, int y2)
{
    int x = (x2 - x1) * (x2 - x1);
    int y = (y2 - y1) * (y2 - y1);
    double result = Math.Sqrt(x + y);
    result = Math.Round(result, 2);
    return result;
}
