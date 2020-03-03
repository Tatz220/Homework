using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string userinput = Console.ReadLine();
      int number = Convert.ToInt32(userinput);

      if (number < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (number >=0 && number <50)
      {
        Console.WriteLine("Fail");
      }
      else if (number >49 && number <60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (number >59 && number <70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (number >69 && number <80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (number >79 && number <90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (number >89 && number <100)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (number >= 100)
      {
        Console.WriteLine("Outstanding!");
      }


    }
  }
}
