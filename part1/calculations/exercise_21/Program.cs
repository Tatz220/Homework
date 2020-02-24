using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userintput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userintput);

      Console.WriteLine("Give the second number!");
      string userinput2 = Console.ReadLine();
      int intvalue2 = Convert.ToInt32(userinput2);

      double average = (intvalue + intvalue2) / 2.0;
      Console.WriteLine("The average is " + average);


    }
  }
}
