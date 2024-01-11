// Задача 42:** Напишите программу, которая будет преобразовывать число в выбранную степень счисления.
// 45 -> 2  = 101101
// 71 -> 8  = 39
// 2 ->  2  = 10
// 45 -> 16 = 91
using System;
using static System.Console;
Clear();

//WriteLine(Convert.ToString(int.Parse(ReadLine()),2));

Write("Введите число: ");
int number = int.Parse(ReadLine());
Write("Введите в какую систему счисления: ");
int degree = int.Parse(ReadLine());

ReverString(DegreeNum(number,degree));

string DegreeNum(int num, int deg)
{
   string result = string.Empty;
   while(num > 0)
   {  
      result += $"{num % deg}";
      num /= deg;
   }
   return result;
}

void ReverString(string str)
{
   for (int i = str.Length; i > 0; i--)
   {
      Write($"{str[i-1]}");
   }
}