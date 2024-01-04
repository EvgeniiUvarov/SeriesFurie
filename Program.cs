// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Drawing;
using static System.Console;
Clear();

WriteLine("Введите длинну массива: ");
int sizar = int.Parse(ReadLine());
double[] randArray = GetRandomArray(sizar);
WriteLine($"{String.Join(' ',randArray)} разница между мксимальным и минемальным: {FestElement(randArray) - SekendElement(randArray)}");

double FestElement(double[] array)
{
   double result = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      result = array[i] > result?array[i]:result;
   }
   return result;
}
double SekendElement(double[] array)
{
   double result = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      result = array[i] < result?array[i]:result;
   }
   return result;
}


double[] GetRandomArray(int size)
{
   double[] array = new double[size];
   for (int i = 0; i < size; i++)
   {
      array[i] = Math.Round(new Random().NextDouble(),2);
   }
   return array;
}

