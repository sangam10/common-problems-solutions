using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class StringExamples
    {
        //problem 1 : Find Most repeated substring from given 
        public static void MostRepeatedString(string inputString, int stringLength)
        {
            Dictionary<string, int> substringCount = new Dictionary<string, int>();

            for (int i = 0; i < inputString.Length - stringLength; i++)
            {
                string subString = inputString.Substring(i, stringLength);
                if (substringCount.ContainsKey(subString))
                {
                    substringCount[subString]++;
                }
                else
                {
                    substringCount.Add(subString, 1);
                }
            }

            //to find most repeated substring
            string MostRepeatedString = substringCount.OrderByDescending(x => x.Value).First().Key;

            Console.WriteLine("Most repeated strng is :" + MostRepeatedString);
        }

        //problem 2 : Find the duplicate characters from the string
        public static void DuplicateCharacterFromString(string inputString)
        {
            StringBuilder result = new StringBuilder();

            StringBuilder duplicate = new StringBuilder();

            foreach (var item in inputString)
            {
                if (result.ToString().Contains(item.ToString().ToLower()))
                {
                    duplicate.Append(item.ToString().ToLower());
                }
                else
                {
                    result.Append(item.ToString().ToLower());
                }
            }

            Console.WriteLine("Duplicate characters are :" + duplicate.ToString().ToLower());
        }

        //problem  3: Get all unique characters from the given string.
        public static void UniqueCharactersFromString(string inputString)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicate = new StringBuilder();

            foreach (var item in inputString)
            {
                if (result.ToString().Contains(item.ToString().ToLower()))
                {
                    duplicate.Append(item.ToString().ToLower());
                }
                else
                {
                    result.Append(item.ToString().ToLower());
                }
            }

            Console.WriteLine("Duplicate characters are :" + result.ToString().ToLower());
        }

        //problem 4: Reverse the single string.

        public static string ReverseString(string inputString)
        {
            string result = "";
            for (var i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }

            return result;
        }

        // Problem 5: Reverse each word of the sentence (string).
        public static void ReverseWords(string inputString)
        {
            string result = "";
            string[] inputArr = inputString.Split(" ");
            foreach (string item in inputArr)
            {
                result += ReverseString(item) + " ";
            }

            Console.WriteLine("reverse string is :" + result);
        }

        //problem 6 : check whether a string is palindrome or not

        public static bool IsStringPalindrome(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return false;
            }
            bool result = false;

            string ReverseString = "";

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                ReverseString += inputString[i];
            }
            if (inputString.Trim() == ReverseString.Trim())
            {
                result = true;
            }
            return result;
        }

        //Problem 7: Check the max occurrence of any character in the string.

        public static void MaxCharOccurance(string inputString)
        {
            char[] input = inputString.ToString().ToLower().Trim().ToCharArray();
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (result.ContainsKey(input[i]))
                    {
                        result[input[i]]++;
                    }
                    else
                    {
                        result.Add(input[i], 1);
                    }
                }
            }

            int count = result.OrderByDescending(x => x.Value).First().Value;

            IEnumerable<KeyValuePair<char, int>> finalResult = result.Where(x => x.Value == count);

            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }

        }

        // Problem 8: Get the possible substring in a string.
        public static void GetPossibleSubString(string inputString)
        {
            List<string> result = new();

            var input = inputString.Trim();

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j <= input.Length - i; j++)
                {
                    result.Add(input.Substring(j, i));
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}