// Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);

int[,] arr = GetArray(rows,colum);
PrintArray(arr);
ChotIndexArray(arr);
WriteLine();
PrintArray(arr);

void ChotIndexArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i,j] = i %2 == 0 && j %2 == 0?array[i,j] *= array[i,j]:array[i,j];
         //if( i %2 == 0 & j %2 == 0) array[i,j] *= array[i,j];
         //if( i %2 == 0 & j %2 == 0) array[i,j] = Convert.ToInt32(Math.Pow(array[i,j],2));
      }
   }
}

int[,] GetArray(int row, int col)
{
   int[,] result = new int[row,col];
   for (int i = 0; i < result.GetLength(0); i++)
   {
      for (int j = 0; j < result.GetLength(1); j++)
      {
         result[i,j] = new Random().Next(1,6);
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
         Write($"{array[i,j]} ");
      }
      WriteLine();
   }
}