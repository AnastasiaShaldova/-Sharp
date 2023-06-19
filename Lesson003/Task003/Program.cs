/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */ 

int RandomNumber(int min, int max){ 
    int result = new Random().Next(min,max+1); 
 
    return result; 
} 
 
void GetSquare(int rand){ 
    Console.WriteLine(rand); 
    for (int i=1;i<=rand;i++){ 
        Console.Write($"{Math.Pow(i,3)} "); 
    } 
} 
 
int rand = RandomNumber(1, 10); 
GetSquare(rand);
