﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int GetSecondNumber(int number)
{
    int result = number / 10 % 10;
    return result;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра - {GetSecondNumber(number)}");
