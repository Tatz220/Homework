using System;

namespace exercise_22
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

      Console.WriteLine("Give the third number!");
      string userinput3 = Console.ReadLine();
      int intvalue3 = Convert.ToInt32(userinput3);

      double average = (intvalue + intvalue2 + intvalue3) / 3.0;
      Console.WriteLine("The average is " + average);

    }
  }
}
