Console.WriteLine("Задайте номер четверти: ");
string quarter = Console.ReadLine();
string result = Coordinats(quarter);
Console.WriteLine(result);

string Coordinats(string digit)
{
    if (digit == "1") return "Диапазон возможных координат точек x>0, y>0";
    if (digit == "2") return "Диапазон возможных координат точек x<0, y>0";
    if (digit == "3") return "Диапазон возможных координат точек x<0, y<0";
    if (digit == "4") return "Диапазон возможных координат точек x>0, y<0";
    return "Заданы некорректные данные";
}


