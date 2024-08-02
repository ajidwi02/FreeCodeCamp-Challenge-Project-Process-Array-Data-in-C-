using System;
class boolean
{
  public static void main(String[] args)
  {
    string value1 = " a";
    string value2 = "A ";
    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

    Console.WriteLine("------------");
    string param = "The quick brown fox jumps over the lazy dog.";
    Console.WriteLine(!param.Contains("fox"));
    Console.WriteLine(!param.Contains("cow"));
    Console.WriteLine("---conditional operator---");
    int saleAmount = 1001;
    Console.WriteLine($"Discount: {(saleAmount > 0 ? 100 : 10)}");
    Console.WriteLine("-----Challenge----");

  }
}

