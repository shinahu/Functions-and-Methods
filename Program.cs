﻿using System;

namespace Task_12
{
    class Program
    {
        static int Fib(int n1)
 {
      if (n1 <=2)
      return 1;
      else
      return Fib( n1 - 1 ) + Fib( n1 - 2 );
 }
public static void Main()
 {
      int num;
  
	     
      Console.Write("Enter a number: ");
      num = Convert.ToInt32( Console.ReadLine() );
   
      Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
 }
    }
}