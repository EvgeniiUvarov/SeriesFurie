// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
using System;
using static System.Console;
Clear();

WriteLine("Введите три числа через пробел: ");
string[] strAr = ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int firstnum = int.Parse(strAr[0]);
int secondnum = int.Parse(strAr[1]);
int thirdnum = int.Parse(strAr[2]);
WriteLine(Triangle(firstnum,secondnum,thirdnum)?"Треугольник":"Не Треугольник");

bool Triangle(int firstnum, int secondnum, int thirdnum)
{
   return firstnum + secondnum > thirdnum && firstnum + thirdnum > secondnum && thirdnum + secondnum > firstnum?true:false;
}
