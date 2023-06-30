/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 
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

int InputNumber()
{
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
    int sum = 0; 
    for (int i = 1; i < numbers.Length; i+=2)
    {
        sum = sum + numbers[i];
    }

    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}"); 
}

RandArray(InputNumber()); 

