using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int amount = 0;
      while(true)
      {
        Console.WriteLine("Give a number:");
        string userinput = Console.ReadLine();
        int intvalue = Convert.ToInt32(userinput);

        if(intvalue ==0)
        {
          break;
        }

        else
        {
          sum = sum + intvalue;
          amount = amount + 1;
        }
      }
      {
        Console.WriteLine("Total sum of numbers: " + sum);
        Console.WriteLine("Total amount of numbers: " + amount);
      }
    }
  }
}
