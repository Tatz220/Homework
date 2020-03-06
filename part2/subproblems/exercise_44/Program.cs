using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int intvalue = Convert.ToInt32(Console.ReadLine());

      int intvalue2 = Convert.ToInt32(Console.ReadLine());

      if (intvalue > intvalue2)
      {
        Console.WriteLine(intvalue + " is greater than " + intvalue2 + ".");
      }
      else if (intvalue < intvalue2)
      {
        Console.WriteLine(intvalue + " is less than " + intvalue2 + ".");
      }
      else
      {
        Console.WriteLine(intvalue + " is equal to " + intvalue2 + ".");
      }



    }
  }
}
