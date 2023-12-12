using System;
using static System.Console;
Clear();

WriteLine("Write number: ");
int numA = int.Parse(ReadLine());

if (Math.Abs(numA) < 99)
{
   WriteLine("Введено не трёх значное число: ");
   return;
}
WriteLine(numA%100%10);



