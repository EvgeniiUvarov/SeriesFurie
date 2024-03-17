// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
using static System.Console;
Clear();

WriteLine("Введите числа m и n через пробел: ");
string[] str = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int numA = int.Parse(str[0]);
int numB = int.Parse(str[1]);

WriteLine(RecursMethod(numB,numA));

int RecursMethod(int numA, int numB)
{
   return numA == 0? numB+1: numB == 0? RecursMethod(numA-1, 1) :RecursMethod(numA-1, RecursMethod(numA, numB-1));
}

