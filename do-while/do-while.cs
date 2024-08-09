using System;

public class doWhile
{
  public static void main(String[] args)
  {
    Random random = new Random();
    int current = random.Next(1, 11);
    do
    {
      current = random.Next(1, 11);
      if (current >= 8)
      {
        continue;
      }
      Console.WriteLine(current);
    }
    while (current != 7);
  }
}