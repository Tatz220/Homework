﻿using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string userage = Console.ReadLine();
      int year = Convert.ToInt32(userage);

      if (year < 1900)
    {
      Console.WriteLine("You're old");
    }

    }
  }
}
