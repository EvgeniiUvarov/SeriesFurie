// Задача 70:** Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно
// сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26
using static System.Console;
Clear();

Write("Введите три числа через пробел: ");
string[] str = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int numA = int.Parse(str[0]);
int numB = int.Parse(str[1]);
int N = int.Parse(str[2]);

RecursMethod(numA, numB, N);

void RecursMethod(int numA, int numB, int N)
{
   if (N > 0)
   {
      Write($"{numA} ");
      RecursMethod(numB, numA + numB, N-1);
   }
}


