using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userinput = Console.ReadLine();
      int year = Convert.ToInt32(userinput);

      if (year == 1984)
    {
    Console.WriteLine("Orwell");
    }
    }
  }
}
