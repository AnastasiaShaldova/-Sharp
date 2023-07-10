/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Clear(); 

string ReturnRealDigits(int startNum, int endNum){ 
    if(startNum <= endNum) return startNum.ToString(); 
    return startNum + " " + ReturnRealDigits(startNum-1, endNum); // " " для преобразования всего рядом в string 
} 

Console.WriteLine("Введите начало: ");
int startNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конец: ");
int endNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ReturnRealDigits(startNum, endNum));