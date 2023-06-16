/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

string GetThirdDigit(int number)
{
    string ConvertNumber = Convert.ToString(number);
    switch (ConvertNumber.Length)
    {
        case > 2:
            return $"Вторя цифра: {ConvertNumber[2]};";

        default:
            return "Третьей цифры нет";
    }
}

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetThirdDigit(number));