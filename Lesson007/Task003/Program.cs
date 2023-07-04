/* 
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear(); 

int [,] CreateArray(int[,] array){ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i,j] = new Random().Next(1, 10); 
        } 
    } 
    return array; 
} 

void ArithmeticMeanColumn(int[,] array, int column){ 
    
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        double SumColumn = 0; 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            SumColumn = (SumColumn + array[i, j]); 
        } 
        SumColumn = SumColumn / column; 
        Console.Write($"{SumColumn}; "); 
    } 
    Console.WriteLine(); 
} 

void PrintArray(int [,] array){ 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        for (int j = 0; j < array.GetLength(0); j++) 
        { 
            Console.Write($"{array [j,i]}\t"); 
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
PrintArray(CreateArray(numbers));
ArithmeticMeanColumn(numbers, column); 