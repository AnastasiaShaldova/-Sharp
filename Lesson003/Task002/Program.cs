/* Задача 21
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D 
пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

void Print (string text){  
   Console.WriteLine(text); 
} 
 
 
int GetIntNumber(){ 
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number; 
} 
 
double FindDistance (int x1, int y1, int a1, int x2, int y2, int a2){ 
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (a2-a1)*(a2-a1)); 
 
    return result; 
} 
 
Print("Insert one by one x1, y1, x2, y2, a1, a2 :"); 
int x1 = GetIntNumber(); 
int y1 = GetIntNumber();
int a1 = GetIntNumber(); 
int x2 = GetIntNumber(); 
int y2 = GetIntNumber(); 
int a2 = GetIntNumber(); 
  
double result = FindDistance(x1, y1, a1, x2, y2, a2); 
Print($"Distance between points is {result}");


