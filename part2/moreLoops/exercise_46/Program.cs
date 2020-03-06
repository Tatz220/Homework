using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userinput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userinput);
      int number = 100;
      
      while (intvalue <= number)
      {
        Console.WriteLine(intvalue);
        intvalue = intvalue +1;
      }

    }
  }
}
