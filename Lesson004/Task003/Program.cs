/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

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

int LenArray = InputFunction("Введите длинну массива: ");
Console.Write("[");
int[] RandomArray = new int[LenArray];
for (int i = 0; i < RandomArray.Length; i++)
{
    RandomArray[i] = new Random().Next(1, 100);
    Console.Write($"{RandomArray[i] + ", "}");
}
Console.Write("]");

