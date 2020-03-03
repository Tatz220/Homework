using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Your speed:");
      string userspeed = Console.ReadLine();
      int speedlimit = Convert.ToInt32(userspeed);

      if (speedlimit > 120)

      {
        Console.WriteLine("Speeding!");
      }
    }
  }
}
