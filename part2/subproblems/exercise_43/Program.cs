using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = -1;
      string userinput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userinput);

      if (intvalue <0)
      {
        Console.WriteLine(intvalue * sum);
      }
      else
      {
        Console.WriteLine(intvalue);
      }
    }
  }
}
