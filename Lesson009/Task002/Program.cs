/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear(); 

int ReturnSumDigits(int startNum, int endNum){ 
    if(startNum <= endNum) 
        return startNum; 
    else 
        return startNum + ReturnSumDigits(startNum+1, endNum); 
}

Console.WriteLine("Введите начало: ");
int startNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конец: ");
int endNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ReturnSumDigits(startNum, endNum));
