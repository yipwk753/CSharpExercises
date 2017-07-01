using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class StringExercises
    {
        #region Helper Methods
        public static string GetStringInput()
        {
            Console.WriteLine("Enter a word or phrase.");
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                Console.WriteLine("You did not enter any words or phrases.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return response;
        }

        public void ExecuteFunction()
        {
            Console.WriteLine("Enter an integer to choose which method to execute:\n1) Reverse String\n2) Check If Number Is A Palindrome\n3) Count Vowels\n4) Reverse Sentence"
                + "\n5) Add Letters");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    {
                        string response = GetStringInput();
                        string reversed = ReverseString(response);
                        Console.WriteLine(response + " reversed is " + reversed);
                        break;
                    }
                case "2":
                    {
                        bool isPalindrome = false;
                        string response = GetStringInput();
                        isPalindrome = CheckIsPalindrome(response);
                        if (isPalindrome == true)
                        {
                            Console.WriteLine(response + " is a palindrome.");
                        }
                        else
                        {
                            Console.WriteLine(response + " is not a palindrome.");
                        }
                        break;
                    }
                case "3":
                    {
                        string str = CountVowels(GetStringInput());
                        Console.WriteLine(str);
                        break;
                    }
                case "4":
                    {
                        string response = GetStringInput();
                        string reversed = ReverseSentence(response);
                        Console.WriteLine(response + " reversed is " + reversed);
                        break;
                    }
                case "5":
                    {
                        string response = GetStringInput();
                        int sum = AddLetters(response);
                        Console.WriteLine("The value of the letters in \"{0}\" is {1}.", response, sum);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You entered a number unassociated with the methods.");
                        break;
                    }
            }
        }
        #endregion

        public int AddLetters(string response)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>
            {
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 },
                { 'd', 4 },
                { 'e', 5 },
                { 'f', 6 },
                { 'g', 7 },
                { 'h', 8 },
                { 'i', 9 },
                { 'j', 10 },
                { 'k', 11 },
                { 'l', 12 },
                { 'm', 13 },
                { 'n', 14 },
                { 'o', 15 },
                { 'p', 16 },
                { 'q', 17 },
                { 'r', 18 },
                { 's', 19 },
                { 't', 20 },
                { 'u', 21 },
                { 'v', 22 },
                { 'w', 23 },
                { 'x', 24 },
                { 'y', 25 },
                { 'z', 26 }
            };
            int sum = 0;
            foreach (char letter in response.ToLower())
            {
                if (letters.Keys.Contains(letter))
                {
                    sum += letters[letter];
                }
            }

            return sum;
        }

        public bool CheckIsPalindrome(string response)
        {
            bool isPalindrome = false;
            string reversed = ReverseString(response);
            if (reversed.ToLower() == response.ToLower())
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        public string CountVowels(string response)
        {
            int a = 0; int e = 0; int i = 0; int o = 0; int u = 0, vowels = 0;
            foreach (var r in response)
            {
                if (r == 'A' || r == 'a')
                {
                    a += 1;
                }
                else if (r == 'E' || r == 'e')
                {
                    e += 1;
                }
                else if (r == 'I' || r == 'i')
                {
                    i += 1;
                }
                else if (r == 'O' || r == 'o')
                {
                    o += 1;
                }
                else if (r == 'U' || r == 'u')
                {
                    u += 1;
                }
            }
            vowels = a + e + i + o + u;
            //string str = response + " has " + vowels + " vowels: " + a + " A's, " + e + " E's, " + i + " I's, " + o + " O's, and " + u + " U's.";
            string str = string.Format("{0} has {1} vowels: {2} A's, {3} E's, {4} I's, {5} O's, and {6} U's.", response, vowels, a, e, i, o, u);
            return str;
        }

        public string ReverseSentence(string response)
        {
            StringBuilder temp = new StringBuilder();
            string[] strArray = response.Split(' ');
            strArray = strArray.Where(x => x != "").ToArray();
            int arrLength = strArray.Length;
            if (arrLength == 1)
            {
                return response;
            }
            temp.Append(strArray[arrLength - 1]);
            for (int i = arrLength - 2; i >= 0; i--)
            {
                temp.Append(" " + strArray[i]);
            }
            string reversed = temp.ToString();
            return reversed;
        }

        public string ReverseString(string response)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = response.Length - 1; i >= 0; i--)
            {
                temp.Append(response[i]);
            }
            string reversed = temp.ToString();
            return reversed;
        }
    }
}
