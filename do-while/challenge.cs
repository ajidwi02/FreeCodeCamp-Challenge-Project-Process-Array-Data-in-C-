using System;
public class challengeDoWhile
{
  public static void main(String[] args)
  {
    Random random = new Random();
    int hero = 10;
    int monster = 10;

    do
    {
      int roll = random.Next(1, 10);
      monster -= roll;
      Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

      if (monster <= 0)
      {
        continue;
      }

      roll = random.Next(1, 10);
      hero -= roll;
      Console.WriteLine($"hero was damaged and lost {roll} health and now has {hero} health.");

    } while (hero > 0 && monster > 0);
    Console.WriteLine(hero > monster ? "Hero Win!" : "Monster Win!");
  }
}