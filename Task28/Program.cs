// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0)
{
    int factorialNumber = FactorialNumber(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {factorialNumber}");
}
else Console.WriteLine("Введено некорректное число");

int FactorialNumber(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked //через checked мы проверяем результат заключенные в скобки на адекватность
        {
        //result = result * i;
        result*=i;
        }
        
    }
    return result;
}