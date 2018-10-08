using System;

namespace Prework_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Add(2, 4);
      Subtract(2, 4);
      Multiply(2, 4);
      Divide(2, 4);
      Console.ReadKey();
    }

    public static float Add(float inputOne, float inputTwo)
    {
      float answer = inputOne + inputTwo;
      Console.WriteLine($"{inputOne} + {inputTwo} is {answer}");
      return answer;
    }
    public static float Subtract(float inputOne, float inputTwo)
    {
      float answer = inputOne - inputTwo;
      Console.WriteLine($"{inputOne} - {inputTwo} is {answer}");
      return answer;
    }
    public static float Multiply(float inputOne, float inputTwo)
    {
      float answer = inputOne * inputTwo;
      Console.WriteLine($"{inputOne} * {inputTwo} is {answer}");
      return answer;
    }
    public static float Divide(float inputOne, float inputTwo)
    {
      float answer = inputOne / inputTwo;
      Console.WriteLine($"{inputOne} / {inputTwo} is {answer}");
      return answer;
    }
  }
}