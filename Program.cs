//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System.Diagnostics;
using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);
int[,] array = GetArray(rows,colum);
PrintArray(array);
ChenchRowCol(array);
WriteLine();
PrintArray(array);
WriteLine();
ChenchColRow(array);
PrintArray(array);

void ChenchRowCol(int[,] array)
{
   for (int i = 0; i < array.GetLength(1); i++)
   {
         int res = array[array.GetLength(0)-1,i];
         array[array.GetLength(0)-1,i] = array[0,i];
         array[0,i] = res;
   }
}

void ChenchColRow(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      int res = array[i,array.GetLength(1)-1];
      array[i,array.GetLength(1)-1] = array[i,0];
      array[i,0] = res;
   }
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