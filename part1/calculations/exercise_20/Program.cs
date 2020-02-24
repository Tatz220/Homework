using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userinput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userinput);

      Console.WriteLine("Give the second number!");
      string userinput2 = Console.ReadLine();
      int intvalue2 = Convert.ToInt32(userinput2);

      int multiply = intvalue * intvalue2;
      Console.WriteLine(intvalue + " * " + intvalue2 + " = " + (multiply));

    }
  }
}
