// Задача 62. Заполните спирально массив 4 на 4
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

using static System.Console;
Clear();

Write("Введите через пробел размер двумерного массива: ");
string[] strAr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(strAr[0]);
int colum = int.Parse(strAr[1]);

int[,] array = new int[rows, colum];

GetArray(array);
PrintArray(array);

void GetArray(int[,] array)
{
   int linEnd = array.GetLength(0) - 1;
   int columEnd = array.GetLength(1) - 1;
   int lineStart = 0;
   int columStart = 0;
   bool top = true;
   bool left = true;
   int i = 0;
   int j = 0;
   int count = 0;
   while (count < array.GetLength(0) * array.GetLength(1))
   {
      count++;
      array[i, j] = count;
      if (left && top)
      {
         if (j == columEnd)
         {
            lineStart++;
            top = true;
            left = false;
            i++;
            continue;
         }
         else
         {
            j++;
            continue;
         }
      }
      if (!left && top)
      {
         if (i == linEnd)
         {
            linEnd--;
            top = false;
            left = false;
            j--;
            continue;
         }
         else
         {
            i++;
            continue;
         }
      }
      if (!left && !top)
      {
         if (j == columStart)
         {
            columStart++;
            top = false;
            left = true;
            i--;
            continue;
         }
         else
         {
            j--;
            continue;
         }
      }
      if (left && !top)
      {
         if (i == lineStart)
         {
            columEnd--;
            top = true;
            left = true;
            j++;
            continue;
         }
         else
         {
            i--;
            continue;
         }
      }
   }
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         string stR = array[i,j] < 10? " "+array[i,j] :array[i,j].ToString();
         Write($"{stR} ");
      }
      WriteLine();
   }
}