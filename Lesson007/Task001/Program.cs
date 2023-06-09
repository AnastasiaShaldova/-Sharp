﻿/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 
*/

Console.Clear(); 

double [,] CreateArray(double[,] array){ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; 
        } 
    } 
    return array; 
} 
 
void PrintArray(double [,] array){ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 
Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[line, column];

CreateArray(numbers);
PrintArray(CreateArray(numbers));
