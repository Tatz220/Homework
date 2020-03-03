using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userinput = Console.ReadLine();
      int number = Convert.ToInt32(userinput);

      Console.WriteLine("Give the second number!");
      string userinput2 = Console.ReadLine();
      int number2 = Convert.ToInt32(userinput2);

      if (number > number2)
      {
        Console.WriteLine("The larger number is " + number + "!");
      }
      else if (number < number2)
      {
        Console.WriteLine("The larger number is " + number2 + "!");
      }
      else if (number == number2)
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}
