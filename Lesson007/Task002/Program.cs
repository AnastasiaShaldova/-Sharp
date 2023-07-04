/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет 
*/

Console.Clear(); 

int [,] CreateArray(int[,] array){ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i,j] = new Random().Next(-10, 10); 
        } 
    } 
    return array; 
} 

void ElementSearch(int[,] array, int line, int column){ 
    if (line > array.GetLength(0) || column > array.GetLength(0)) {
        Console.WriteLine("Такого числа в массиве нет"); 
    }
    else {
        Console.WriteLine($"Значение элемента в массиве: {array[line - 1, column - 1]}");
    }

} 

void PrintArray(int [,] array){ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 
Console.WriteLine("Введите № строки: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите № столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[5, 5];

CreateArray(numbers);
PrintArray(CreateArray(numbers));
ElementSearch(numbers, line, column); 