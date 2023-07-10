/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear(); 

void CreateArray(int[,] array){ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
} 

void MinSumStringArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0; 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; 
        }
        Console.Write($"{sum} ");
    } 
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[line, column];

CreateArray(numbers);
PrintArray(numbers); 

Console.WriteLine("*********************************");  

MinSumStringArray(numbers);

