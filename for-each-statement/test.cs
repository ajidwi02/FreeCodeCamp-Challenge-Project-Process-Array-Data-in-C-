using System;
public class testFor
{
  public static void main(String[] args)
  {
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = 0; i < names.Length; i++)
    {
      if (names[i] == "David")
      {
        names[i] = "Aji";
      }
    }
    foreach (var name in names)
    {
      Console.WriteLine(name);
    }
  }
}