// Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

Write("Введите число: ");
int numFeb = int.Parse(ReadLine());
NumberFebonachi(numFeb);

WriteLine();
WriteLine($"{String.Join(' ', FebonachArray(numFeb))}");

void NumberFebonachi(int num)
{
   int first = 0;
   int second = 1;
   Write($"{first} ");
   Write($"{second} ");
   for (int i = 2; i < num; i++)
   {
      int result = first + second;
      Write($"{result} ");
      first = second;
      second = result;
   }
}

int[] FebonachArray(int num)
{
   int[] result = new int[num];
   for (int i = 2; i < num; i++)
   {
      result[0] = 0;
      result[1] = 1;
      result[i] = result[i-1] + result[i-2];
   }
   return result;
}