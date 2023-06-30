/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/ 

void Print(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
    Console.Write("]");
}

int InputNumber(){
    Console.WriteLine("Введите число: "); 
    int input = Convert.ToInt32(Console.ReadLine()); 
    return input; 
}

void RandArray(int numb)
{   
    int[] RandomArray = new int[numb];
    for (int i = 0; i < numb; i++)
    {
        RandomArray[i] = new Random().Next(99, 1000);
    }
    ShowNumber(RandomArray); 
    Print(RandomArray); 
}

void ShowNumber(int[] numbers){
    int count = 0; 
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count += 1; 
        }
    }
    Console.WriteLine($"Количество четных чисел: {count}"); 
}

RandArray(InputNumber()); 


