/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

string IsPalindrom(string word)
{
    word = word.ToLowerInvariant();

    for (int start = 0, end = word.Length - 1; start < end; ++start, --end)
    {
        if (word[start] != word[end])
        {
            return "Это не палиндром";
        }
    }

    return $"{word} - Это палиндром";
}
Console.WriteLine("Введите строку: ");
string text = Console.ReadLine(); 
Console.WriteLine(IsPalindrom(text)); 