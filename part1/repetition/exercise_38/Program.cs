using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
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
      sum = sum +1;
      }
      else
      {
        continue;
      }
      }
      Console.WriteLine("Total amount of negative numbers: " + sum);
    }
  }
}
