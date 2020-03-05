using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userinput = Console.ReadLine();
      int number = Convert.ToInt32(userinput);

      string userinput2 = Console.ReadLine();
      int number2 = Convert.ToInt32(userinput2);

      int sum = number + number2;

      double squareRoot = Math.Sqrt(sum);
      Console.WriteLine(squareRoot);
    
    }
  }
}
