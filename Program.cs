using System;

class Program
{

  public static bool PalindromeIntegerChecker(int inputNumber)
  {
    int number = inputNumber;
    int newNumber = 0;
    while (number > 0)
    {
      newNumber = newNumber * 10 + number % 10;
      number = number / 10;
    }

    if (inputNumber != newNumber)
    {
      return false;
    }
    return true;
  }

  public static bool PalindromeStringChecker(string inputString)
  {
    char[] inputArray = inputString.ToCharArray();

    for(int i = 0; i < inputArray.Length / 2; i++)
    {
      if (inputArray[i] != inputArray[inputArray.Length - 1 - i])
      {
        return false;
      }
    }
    return true;
  }

  public static void Main()
  {
    Console.WriteLine("Would you like to check a phrase or a number if it's a palindrome? P for phrase, N for number, Enter to exit");

    string whatToCheck = Console.ReadLine().ToUpper();

    if ((whatToCheck == "P") || (whatToCheck == "N"))
    {
      Console.WriteLine("Enter what you would like to check if it's a palindrome:");
      string inputString = Console.ReadLine().ToUpper();

      if (((whatToCheck == "P") && (PalindromeStringChecker(inputString))) || ((whatToCheck == "N") && (PalindromeIntegerChecker(int.Parse(inputString)))))
//      if (isPalindrome)
      {
        Console.WriteLine("It's a palindrome.");
      }
      else
      {
        Console.WriteLine("It is NOT a palindrome.");
      }

      Console.WriteLine("Would you like to make another check? Y for yes, enter for no");
      if (Console.ReadLine().ToUpper() == "Y")
      {
        Main();
      }
    }
  }
}
