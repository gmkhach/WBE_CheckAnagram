﻿using System;
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
                    Console.WriteLine("\n" + (CheckAnagram(input[0].Trim(), input[1].Trim()) ? "the strings are anagrams of each other" : "the strings are not anagrams of each other"));
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
            if (input1.Length != input2.Length)
            {
                return false;
            }
            for (int i = 0; i < input1.Length / 2; i++)
            {
                if (input1[i] != input2[input2.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
