﻿using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      
      Console.WriteLine("Give the second number!");
      string userInput2 = Console.ReadLine();
      int intValue2 = Convert.ToInt32(userInput2);

      Console.WriteLine(intValue + " + " + intValue2 + " = " + (intValue + intValue2));


    }
  }
}
