﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

class Program 
{




  static void n(int i)
  {
      System.Console.WriteLine(i);

      if (i <= 1)
        return;


      i--;
      n(i);
  }


  static void Main(string[] args)
  {
      n(8);
  }
}