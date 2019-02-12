using System;

class Program
{
  public static void Main(){

    Console.WriteLine("Enter the phrase to check if it's a palindrome:");
    string inputString = Console.ReadLine().ToUpper();

    char[] inputArray = inputString.ToCharArray();
    char[] reverseArray = inputString.ToCharArray();
    System.Array.Reverse(reverseArray);

    // Console.WriteLine(inputArray);
    // Console.WriteLine(reverseArray);

    bool isPalindrome = true;
    for(int i = 0; i < inputArray.Length; i++)
    {
      if (inputArray[i] != reverseArray[i])
      {
        isPalindrome = false;
        break;
      }
    }

    if (isPalindrome)
    {
      Console.WriteLine("It's a palindrome.");
    }
    else
    {
      Console.WriteLine("It is NOT a palindrome.");
    }

    Console.WriteLine("Would you like to check another phrase? Y for yes, enter for no");
    if (Console.ReadLine().ToUpper() == "Y")
    {
      Main();
    }
  }
}
