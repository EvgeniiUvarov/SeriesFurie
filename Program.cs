// Джеку очень нравится его число пять: фокус здесь в том, что вам нужно умножить каждое число на 5, возведенное в ранг 
// количества цифр каждого числа, так, например:
//   3 -->    15  (  3 * 5¹)
//  10 -->   250  ( 10 * 5²)
// 200 --> 25000  (200 * 5³)
//   0 -->     0  (  0 * 5¹)
//  -3 -->   -15  ( -3 * 5¹)
using static System.Console;
Clear();

WriteLine("Введите число: ");
int num = int.Parse(ReadLine());
WriteLine($"{Multiply(num)}");


int Multiply(int number)
{
   return number * Convert.ToInt32(Math.Pow(5, Math.Abs(number).ToString().Length));
}

