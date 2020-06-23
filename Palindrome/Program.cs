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
                
                } catch(OverflowException exc)
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

                while (x != 0)
                {
                    tmp = 10 * tmp + x % 10;
                    x = x / 10;
                }

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
                    for (; (((str[i] < 65) || ((str[i] > 90) && (str[i] < 97)) || (str[i] > 122))) && (i <= j); i++) 
                    { if (i == j) return true; }; // returning true, when string doesn't contain letters
                    for (; (((str[j] < 65) || ((str[j] > 90) && (str[j] < 97)) || (str[j] > 122))) && (j >= i); j--);
                    { if (i == j) return true; }; // returning true, when string doesn't contain letters

                    char k = Char.ToLower(str[i]);
                    char o = Char.ToLower(str[j]);

                    if (o == k) { i++; j--; }
                    else return false;
                    //continue;

                }

                return true;

            }


        }
 }

