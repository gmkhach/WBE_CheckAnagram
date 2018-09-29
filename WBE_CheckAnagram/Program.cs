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
                    Console.Write("Input a string\n\n>>> ");
                    string input1 = Console.ReadLine().Trim();
                    Console.Write("Input a string\n\n>>> ");
                    string input2 = Console.ReadLine().Trim();
                    if (CheckAnagram(input1, input2))
                    {
                        Console.WriteLine("the strings are anagrams of each other");

                    }
                    else
                    {
                        Console.WriteLine("the strings are not anagrams of each other");
                    }
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
            string reverseInput1 = "";
            // create a FILO data structure to prepare for reverseing input1
            Stack myStack = new Stack();
            foreach (var ch in input1)
            {
                myStack.Push(ch);
            }
            // build the reverse string of input1
            while(myStack.Count != 0)
            {
                reverseInput1 += myStack.Pop();
            }
            // compare the reversed input1 to input2
            if (reverseInput1 == input2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
