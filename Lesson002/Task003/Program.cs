/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

string DayOfTheWeek(int day)
{
    switch (day)
    {
        case > 0 and < 6:
            return "Будний день недели";

        case 6:
        case 7:
            return "Выходной";

        default:
            return "Это не день недели";
    }
}

Console.Write("Введи номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayOfTheWeek(day));