/*Решение в группах задач:
12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

int firstDigit = new Random().Next(10, 100);
int secondDigit = new Random().Next(1, 10);
Console.Write($"{firstDigit}, {secondDigit}");
//string del = FuncDel(firstDigit, secondDigit);
int delOst = firstDigit % secondDigit;
if (delOst==0) Console.Write("-> кратно");
else Console.Write($" -> не кратно, остаток {delOst}");

/*string FuncDel(int Dig1, int Dig2)
{
    string result;
    if (Dig1 % Dig2 = 0) result = "кратно";
    result = "не кратно";
    return result;
}*/

