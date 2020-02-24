using System;

namespace exercise_23
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


      Console.WriteLine(intvalue + " + " + intvalue2 + " = " + (intvalue + intvalue2));
      Console.WriteLine(intvalue + " - " + intvalue2 + " = " + (intvalue - intvalue2));
      Console.WriteLine(intvalue + " * " + intvalue2 + " = " + (intvalue * intvalue2));
      Console.WriteLine(intvalue + " / " + intvalue2 + " = " + ((double)intvalue / intvalue2));

    }
  }
}
