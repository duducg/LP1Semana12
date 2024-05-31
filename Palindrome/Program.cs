using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool isPalidrome = CheckPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalidrome}");
            }
            bool CheckPalindrome(string input)
            {
                bool CheckPalindromefrfr(string inpass)
                {
                    char[] tupni = inpass.ToCharArray();
                    Array.Reverse(tupni);
                    string newtupni = new string(tupni);
                    if (newtupni == inpass) return true;
                    else return false;
                }

                if (input == null) throw new ArgumentNullException();
                if (input.Length < 2) return true;
                else  return CheckPalindromefrfr(input);              
                
                
                

            }
        }
    }
}
