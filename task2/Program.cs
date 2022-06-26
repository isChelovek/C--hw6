// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

using System;
using static System.Console;
Clear();

Write("Введите b1: ");
int numb1 = int.Parse(ReadLine());
Write("Введите k1: ");
int numk1 = int.Parse(ReadLine());

Write("Введите b2: ");
int numb2 = int.Parse(ReadLine());
Write("Введите k2: ");
int numk2 = int.Parse(ReadLine());

WriteLine(findCrossPoint(numb1, numk1, numb2, numk2));

string findCrossPoint(int b1, int k1, int b2, int k2)
{
       string str1 = "";
       string str2 = "";
    for (double x = -10; x < 10; x+=0.1)
    {
     str1 = $"({k1 * x + b1:f2})";
     str2 = $"({k2 * x + b2:f2})";

       if (str1 == str2)
       {
            return $"Точка пересечения равна: ({x:f1}; {k1 * x + b1:f1})";
       }
    } 
    return "Точки пересечени нет"; 
}
