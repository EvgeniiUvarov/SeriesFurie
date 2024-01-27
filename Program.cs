// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System.Diagnostics;
using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);
int[,] array = GetArray(rows, colum);
PrintArray(array);

WriteLine($"{String.Join(' ',SerchPositionElement(array))}");

double[] SerchPositionElement(int[,] array)
{
   double[] result = new double[array.GetLength(1)];

   for (int i = 0; i < array.GetLength(1); i++)
   {
      double sum = 0;
      for (int j = 0; j < array.GetLength(0); j++)
      {
         sum += array[j,i];
      }
      result[i] = sum/array.GetLength(0);
   }
   return result;
}

int[,] GetArray(int row, int col)
{
   int[,] result = new int[row, col];
   for (int i = 0; i < result.GetLength(0); i++)
   {
      for (int j = 0; j < result.GetLength(1); j++)
      {
         result[i, j] = new Random().Next(1, 10);
      }
   }
   return result;
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Write($"{array[i, j]} ");
      }
      WriteLine();
   }
}