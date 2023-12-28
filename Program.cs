// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;
using static System.Console;
Clear();

Write("Введите числа: ");
WriteLine(ArrStep(int.Parse(ReadLine())));

int ArrStep(int an)
{
   int result = 0;
   while (an > 0)
   {
      result += an%10;
      an /= 10;

   }
   return result;
}


