using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please, input a number.");
    string input = Console.ReadLine();

    int sum = 0;

    for (int i = 0; i < input.Length; i++)
    {
      char c = input[i];
      int number = int.Parse(c.ToString());
      sum = sum + number;
    }

    Console.WriteLine("Sum = {0}", sum);
  }
}
