using System;

public class coinFlip
{
  public static void main(String[] args)
  {
    Random random = new Random();
    string result = (random.Next(0, 2) == 0) ? "Head" : "Tails";
    Console.WriteLine($"Coin flip result: {result}");
  }
}