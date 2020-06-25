using System;

namespace Palindrome
{

    class Solution
    {
        static void Main(string[] args)
        {

            string choice = "";
            Console.WriteLine("Select the desired operation:\n1. Checking the number on the palindrome\n" +
                              "2. Make the return number\n" + "3. Checking a string on a palindrome");


            try
            {

                choice = Console.ReadLine();

                // Responsible for choosing the required function
                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Enter the number for checking:\n");
                        string checkingNumberHolder = Console.ReadLine();
                        int checkingNumber = Convert.ToInt32(checkingNumberHolder);
                        Console.WriteLine(IsPalindrome(checkingNumber));
                        break;


                    case "2":
                        Console.WriteLine("Enter the number you want to reverse:\n");
                        string reverseNumberHolder = Console.ReadLine();
                        int reverseNumber = Convert.ToInt32(reverseNumberHolder);
                        Console.WriteLine(Reverse(reverseNumber));
                        break;


                    case "3":
                        Console.WriteLine("Enter the string you want to check:\n");
                        var reverseStr = Console.ReadLine();
                        Console.WriteLine(IsPalindrome(reverseStr));
                        break;

                    default:
                        Console.WriteLine("You've entered an inappropriate value");
                        break;

                }

            }
            catch (OverflowException exc)
            {
                Console.WriteLine("Message:\n   {0}\n", exc.Message);
            }

            //  int n = -121;

            //  Console.WriteLine(IsPalindrome(n));
            //  Console.WriteLine(Reverse(n));
            //   Console.WriteLine(IsPalindrome(")?KAAK>?"));


        }

        // Boolean True if the passed number is a palindrome; otherwise - false
        static public bool IsPalindrome(int x)
        {

            if ((x >= 0) && (x == Reverse(x))) return true;
            else return false;

        }


        // A function that reverses a number. If the number is negative, for example, (-201), then the output is (-102)
        static public int Reverse(int x)

        {
            int tmp = 0;
            try
            {



                while (x != 0)
                {
                    checked { tmp = 10 * tmp + x % 10; }
                    x = x / 10;

                }

            }
            catch (OverflowException) { return 0; };
            return tmp;




        }


        // A function that returns a True boolean value if the passed string is a palindrome, otherwise it is False. 
        // All characters except Latin letters are ignored.
        // For instance "??--aha\/" - output is True
        static public bool IsPalindrome(string str)
        {

            int i = 0, j = str.Length - 1; ;

            while (i < j)
            {
                IsSymbolNotALatinLetter(ref i, ref j, str);
                //IsSymbolNotALatinLetter(ref j, str);

                if (i == j) return true;
                else
                {
                    char k = Char.ToLower(str[i]);
                    char o = Char.ToLower(str[j]);

                    if (o == k) { i++; j--; }
                    else return false;

                }

            }
            return true;

        }

        // Helper function to skip all non-latin characters
        static void IsSymbolNotALatinLetter(ref int leftIndexvalue, ref int rightIndexValue, string str)
        {
            // Checking if the next character is different from the Latin letter
            while (((str[leftIndexvalue] < 65) || ((str[leftIndexvalue] > 90) && (str[leftIndexvalue] < 97)) || (str[leftIndexvalue] > 122)))
            {     
                if (leftIndexvalue < rightIndexValue) leftIndexvalue++;
                   
                    
                else return;
            }

            // Checking if the next character is different from the Latin letter
            while (((str[rightIndexValue] < 65) || ((str[rightIndexValue] > 90) && (str[rightIndexValue] < 97)) || (str[rightIndexValue] > 122)))
            {
                if (rightIndexValue > leftIndexvalue) rightIndexValue--;

                else return;
            }
        }

    }
}
 

