using System;
public class test
{
  public static void main(String[] args)
  {
    int employeelevel = 100;
    string employeeName = "john Smith";

    string tittle = "";
    switch (employeelevel)
    {
      case 100:
      // tittle = "Junior Associate";
      // break;
      case 200:
        tittle = "Senior Associate";
        break;
      case 300:
        tittle = "Manager";
        break;
      case 400:
        tittle = "Senior Manager";
        break;
      default:
        tittle = "Associate";
        break;
    }
    Console.WriteLine($"{employeeName}, {tittle}");
  }

}