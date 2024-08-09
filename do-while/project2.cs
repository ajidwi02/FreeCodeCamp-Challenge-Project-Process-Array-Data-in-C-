using System;
public class p2
{
  public static void main(string[] args)
  {
    string? readResult;
    string roleName = "";
    bool validEntry = false;

    do
    {
      Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
      readResult = Console.ReadLine();
      if (readResult != null)
      {
        roleName = readResult.Trim();
      }
      if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
      {
        validEntry = true;
      }
      else
      {
        Console.WriteLine($"The role name that you enterd, \"{roleName}\" is not valid.");
      }
    } while (validEntry == false);
    Console.WriteLine($"Yout input value ({roleName}) has been accepted");
    readResult = Console.ReadLine();
  }
}