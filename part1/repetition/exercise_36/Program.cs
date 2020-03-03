using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
      {
      Console.WriteLine("Give a number:");
      string userinput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userinput);

      if (intvalue ==0)
      {
        break;
      }
      else if (intvalue <0)
      {
      Console.WriteLine("That is negative");
      }
      else if (intvalue >0)
      {
      Console.WriteLine(intvalue * intvalue);
      }
      }
    }
  }
}
