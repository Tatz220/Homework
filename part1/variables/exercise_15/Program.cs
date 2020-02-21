using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();

      Console.WriteLine("Give an integer:");
      string userInputInt = Console.ReadLine();
      int intValue = Convert.ToInt32(userInputInt);

      Console.WriteLine("Give a double:");
      string userInputDouble = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userInputDouble);
      
      Console.WriteLine("Give a boolean:");
      string booleanInput = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(booleanInput);

      Console.WriteLine("Your string:" + message);
      Console.WriteLine("Your integer:" + userInputInt);
      Console.WriteLine("Your double:" + userInputDouble);
      Console.WriteLine("Your boolean:" + booleanInput);

    }
  }
}
