using System;
using static System.Console;
Clear();

string cout = string.Empty;

  for(int i=1;i<101;i++)
  {
      cout += i%3==0?$" Fiz({i})": i%5==0?$" Buzz({i})":" ";
      if(i%3==0 && i%5==0) cout +=$" Eys({i})";
  }

WriteLine(cout);