using System;

namespace Prework_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      //Calls up all methods in calculator with specified parameters of 2 and 4
      float inputOne = 2;
      float inputTwo = 4;
      Add(inputOne, inputTwo);
      Subtract(inputOne, inputTwo);
      Multiply(inputOne, inputTwo);
      Divide(inputOne, inputTwo);
      //prevent console from automatically exiting
      Console.ReadKey();
    }

    //summing method, writes to console and returns results.
    public static float Add(float inputOne, float inputTwo)
    {
      float answer = inputOne + inputTwo;
      Console.WriteLine($"{inputOne} + {inputTwo} is {answer}");
      return answer;
    }
    //subtract method, writes to console and returns results.
    public static float Subtract(float inputOne, float inputTwo)
    {
      float answer = inputOne - inputTwo;
      Console.WriteLine($"{inputOne} - {inputTwo} is {answer}");
      return answer;
    }
    //multiply method, writes to console and returns results.
    public static float Multiply(float inputOne, float inputTwo)
    {
      float answer = inputOne * inputTwo;
      Console.WriteLine($"{inputOne} * {inputTwo} is {answer}");
      return answer;
    }
    //division method, writes to console and returns results.
    public static float Divide(float inputOne, float inputTwo)
    {
      float answer = inputOne / inputTwo;
      Console.WriteLine($"{inputOne} / {inputTwo} is {answer}");
      return answer;
    }
  }
}