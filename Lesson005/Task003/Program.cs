/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

void Print(double[] numbers)
{
    Console.Write("[");

    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:F3}, ");
    }

    Console.WriteLine("]");
}

int InputNumber()
{
    Console.WriteLine("Введите число: "); 
    int input = Convert.ToInt32(Console.ReadLine()); 
    return input; 
}

void RandArray(int numb)
{   
    double[] RandomArray = new double[numb];

    for (int i = 0; i < numb; i++)
    {
        RandomArray[i] = new Random().NextDouble() + new Random().Next(1, 10);
    }

    ShowNumber(RandomArray);
    Print(RandomArray);
}

void ShowNumber(double[] numbers){
    double min = (int) numbers[0];
    double max = (int) numbers[0];
    double fractional_min = numbers[0] - min; 
    double fractional_max = numbers[0] - max; 
    for (int i = 0; i < numbers.Length; i++)
    {
        double numb = numbers[i] - (int) numbers[i]; 
        if (fractional_max < numb){
            fractional_max = numb; 
        }
        if (fractional_min > numb){
            fractional_min = numb; 
        }
    }

    Console.WriteLine($"Разница между максимальной и минимальной вещественной частью элементов массива: {fractional_max - fractional_min:F3}"); 
}

RandArray(InputNumber()); 
