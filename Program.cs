// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);

int[,] array = GetArray(rows, colum);
PrintArray(array);
SerchMinSumLineArray(array);

void SerchMinSumLineArray(int[,] array)
{
   int lineIndex = 1;
   int curentSum = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      int sum = 0;
      for (int j = 0; j < array.GetLength(1); j++)
      {
         sum += array[i, j];
      }
      if(i == 0) curentSum = sum; 
      if (curentSum > sum)
      {
         curentSum = sum;
         lineIndex = i+1;
      }
   }
   WriteLine($"В {lineIndex} строке, сумма элементов {curentSum}");
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