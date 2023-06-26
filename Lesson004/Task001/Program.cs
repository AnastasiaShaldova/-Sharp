/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

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

// Решение 1
/* double CubingANumber(int numbA, int numbB)
{
    double result = Math.Pow(numbA, numbB);
    return result;
} */

// Решение 2
int CubingANumber(int numbA, int numbB)
{
    int result = 1;
    for (int i = 1; i <= numbB; i++)
    {
        result *= numbA;
    }
    return result;
}

int numberA = InputFunction("Введите число A: ");
int numberB = InputFunction("Введите число B: ");

Print($"{CubingANumber(numberA, numberB)}");




