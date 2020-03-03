using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string userinput = Console.ReadLine();

      Console.WriteLine("Give the second string:");
      string userinput2 = Console.ReadLine();

      if (userinput == userinput2)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }
    }
  }
}
