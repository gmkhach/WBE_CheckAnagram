/**
 * Given two strings s and t, write a function to determine if t is an anagram of s.
 * ie: 'rat' and 'car' returns false, 'rat' and 'tar' returns true
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WBE_CheckAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nInput two string separated by a comma\n\n>>> ");
                    string[] input = Console.ReadLine().Trim().Split(',');
                    Console.WriteLine("\nThe strings are " + (CheckAnagram(input[0].Trim(), input[1].Trim()) ? "" : "not ") + "anagrams of each other");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static bool CheckAnagram(string input1, string input2)
        {
            if (input1.Length == input2.Length)
            {
                foreach (var ch in input1)
                {
                    if (input2.Contains(ch))
                    {
                        input2 = input2.Remove(input2.IndexOf(ch), 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
