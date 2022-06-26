// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 
// 0, 7, 8, -2, -2 -> 2
// 
// 1, -7, 567, 89, 223-> 3

using System;
using static System.Console;
using MyLib;

Clear();
Write("Введите уровень подсчета чисел: ");
int levelNum = int.Parse(ReadLine());
 Write("Введите страку: ");
int[] array = Class1.GetArrayFromString(ReadLine());
WriteLine($"Чисел в массиве {Class1.arrayToString(array)} более {levelNum} равно: {countLevel(array, levelNum)}");

int countLevel(int [] findThere, int level)
{
    int count = 0;
    for (int i = 0; i < findThere.Length; i++)
    {
        if (findThere[i] > level) count++;
    }
    return count;
}


