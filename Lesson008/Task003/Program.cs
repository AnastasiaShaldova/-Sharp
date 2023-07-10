/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
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

int [,] MultiplicationOfTwoMatrices(int [,] array1, int [,] array2){
    var resultArray = new int[array1.GetLength(0), array2.GetLength(1)]; 
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = 0; 
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j]; 
            }
        }
    }
    return resultArray; 
}

Console.WriteLine("Введите количество строк первого массива: ");
int line1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первого массива: ");
int column1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второго массива: ");
int line2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второго массива: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] numbers1 = new int[line1, column1];
int[,] numbers2 = new int[line2, column2];


CreateArray(numbers1);
PrintArray(numbers1); 
Console.WriteLine("*********************************");
CreateArray(numbers2);
PrintArray(numbers2); 
Console.WriteLine("*********************************");  
MultiplicationOfTwoMatrices(numbers1, numbers2); 
PrintArray(MultiplicationOfTwoMatrices(numbers1, numbers2)); 
