/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

int InputFunction(string number)
{
    Console.WriteLine(number);
    return Convert.ToInt32(Console.ReadLine());
}

void Print(string mess)
{
    Console.WriteLine(mess);
}

int SumOfDigits(int numb)
{
    string convertInt = Convert.ToString(numb);
    int sum = 0;
    for (int i = 1; i <= convertInt.Length; i++)
    {
        sum += numb % 10;
        numb /= 10;
    }
    return sum;
}

int number = InputFunction("Введите число: ");

Print($"{SumOfDigits(number)}");
