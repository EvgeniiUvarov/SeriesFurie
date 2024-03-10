//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень В с помощью рекурсии.
//А = 3; B = 5 -> 243
//A = 2; B = 3 -> 8
using System.Reflection.Metadata.Ecma335;
using static System.Console;
Clear();

Write("Введите два числа через пробел: ");
string[] str = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int numA = int.Parse(str[0]);
int numB = int.Parse(str[1]);

WriteLine(RecursMethod(numA,numB));

int RecursMethod(int numA, int numB)
{
   return numB > 0 ?numA * RecursMethod(numA,numB-1): 1;
}