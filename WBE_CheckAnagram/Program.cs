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
                    Console.WriteLine("\n" + ( CheckAnagram(input[0].Trim(), input[1].Trim()) ? "the strings are anagrams of each other" : "the strings are not anagrams of each other" ));
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
            return reverseInput1 == input2 ? true : false;
        }
    }
}
