using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userinput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userinput);
      int number = 0;
      
      while(number <= intvalue)
      {
        Console.WriteLine(number);
        number = number +1;
      }

    }
  }
}
