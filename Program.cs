// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
using System.Drawing;
using static System.Console;
Clear();

WriteLine("Введите длинну массива: ");
int sizar = int.Parse(ReadLine());
int[] randArray = GetRandomArray(sizar);
WriteLine($"{String.Join(' ',randArray)} положительных элементов в массиве: {FyndElement(randArray)}");

int FyndElement(int[] array)
{
   int result = 0;
   for (int i = 0; i < array.Length; i++)
   {
      result += array[i] %2== 0?1:0;
   }
   return result;
}

int[] GetRandomArray(int size)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(100,1000);
   }
   return array;
}

