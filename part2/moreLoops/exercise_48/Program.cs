using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int number = 0;
      double average = 0.00;
      int even = 0;
      int odd = 0;

      while(true)
      {
        Console.WriteLine("Give numbers:");
        string userinput = Console.ReadLine();
        int intvalue = Convert.ToInt32(userinput);

        if (intvalue ==-1)
        {
          break;
        }
        sum = sum + intvalue;
        number = number +1;
        average = (double)sum / number;

        if ((intvalue % 2) ==0)
        {
          even = even +1;
        }
        else
        {
          odd =odd +1;
        }

      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + number);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
 
    }
  }
}
