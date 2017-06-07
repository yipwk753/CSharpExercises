﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class IntegerExercises
    {
        #region Helper Methods
        public static int GetIntegerInput()
        {
            Console.WriteLine("Enter a non-zero whole number.");
            int response = 0;
            Int32.TryParse(Console.ReadLine(), out response);
            if (response == 0)
            {
                Console.WriteLine("You did not enter a number, you entered a zero, or you entered a number " +
                    "with a decimal.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return response;
        }

        public static int GetPositiveIntegerInput()
        {
            Console.WriteLine("Enter a non-zero positive whole number.");
            int response = 0;
            Int32.TryParse(Console.ReadLine(), out response);
            if (response <= 0)
            {
                Console.WriteLine("You did not enter a number, you entered a zero, you entered a negative number, or you entered a number " +
                    "with a decimal.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return response;
        }

        public void ExecuteFunction()
        {
            Console.WriteLine("Enter an integer to choose which method to execute:\n1) FizzBuzz\n2) Check If Number Is Composite\n3) Find LCD Of Two Numbers" +
                "\n4) Prime Number Sieve\n5) Fibonacci Sequence\n6) Multiples of 3 and 5\n7) Even Fibonacci Numbers Sum\n8) Largest Prime Factor\n9) Largest Palindrome Product");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    {
                        FizzBuzz(GetIntegerInput());
                        break;
                    }
                case "2":
                    {
                        int input = GetIntegerInput();
                        List<int> numList = CheckIfCompositeNumber(input);
                        if (numList.Count != 0)
                        {
                            Console.WriteLine(input + " is a composite number. Its factor(s) are " + string.Join(", ", numList) + ".");
                        }
                        else
                        {
                            Console.WriteLine(input + " is not a composite number.");
                        }
                        break;
                    }
                case "3":
                    {
                        int input1 = GetPositiveIntegerInput();
                        int input2 = GetPositiveIntegerInput();
                        int lcdNum = FindLeastCommonDenominator(input1, input2);
                        Console.WriteLine("The LCD of {0} and {1} is {2}.", input1, input2, lcdNum);
                        break;
                    }
                case "4":
                    {
                        int input = GetPositiveIntegerInput();
                        List<int> primeNumList = PrimeNumberSieve(input);
                        Console.WriteLine("The prime numbers from 1 to " + input + " are " + string.Join(", ", primeNumList) + ".");
                        break;
                    }
                case "5":
                    {
                        int input = GetPositiveIntegerInput();
                        List<int> sequence = FibonacciSequence(input);
                        Console.WriteLine("The Fibonacci sequence is " + string.Join(" ", sequence) + ".");
                        break;
                    }
                case "6":
                    {
                        int input = GetIntegerInput();
                        int sum = MultiplesOf3And5(input);
                        Console.WriteLine("The sum of the 3 and 5 multiples of " + input + " is " + sum + ".");
                        break;
                    }
                case "7":
                    {
                        int input = GetPositiveIntegerInput();
                        int sum = EvenFibonacciNumbersSum(input);
                        Console.WriteLine("The sum of the even numbers in the Fibonacci sequence is " + sum + ".");
                        break;
                    }
                case "8":
                    {
                        int input = GetPositiveIntegerInput();
                        int primeFactor = LargestPrimeFactor(input);
                        Console.WriteLine("The largest prime number of {0} is {1}.", input, primeFactor);
                        break;
                    }
                case "9":
                    {
                        Tuple<int, int, bool> tuple = LargestPalindromeProduct(GetPositiveIntegerInput(), GetPositiveIntegerInput());
                        if (tuple.Item3)
                        {
                            Console.WriteLine("The numbers {0} and {1} created the palindrome {2}.", tuple.Item1, tuple.Item2, tuple.Item1 * tuple.Item2);
                        }
                        else
                        {
                            Console.WriteLine("The inputted numbers did not create a palindrome.");
                        }
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

        public List<int> CheckIfCompositeNumber(int input)
        {
            List<int> numList = new List<int>();
            if (input > 0)
            {
                for (int i = 2; i < (input / 2 + 1); i++)
                {
                    if (input % i == 0)
                    {
                        numList.Add(i);
                    }
                }
            }
            else
            {
                for (int i = -2; i > (input / 2 - 1); i--)
                {
                    if (input % i == 0)
                    {
                        numList.Add(i);
                    }
                }
            }
            return numList;
        }

        public int EvenFibonacciNumbersSum(int input)
        {
            int num1 = 0, num2 = 1, sum = 0, tempnum = 0;
            if (input == 1)
            {
                return 0;
            }
            if (input == 2)
            {
                return 1;
            }
            for (int i = 2; i < input; i++)
            {
                tempnum = num1 + num2;
                if (tempnum % 2 == 0)
                {
                    sum += tempnum;
                }
                num1 = num2;
                num2 = tempnum;
            }
            return sum;
        }

        public List<int> FibonacciSequence(int input)
        {
            int num1 = 0;
            int num2 = 1;
            int tempNum = 0;
            List<int> sequence = new List<int>();
            if (input == 1)
            {
                sequence.Add(num1);
                return sequence;
            }
            sequence.Add(num1);
            sequence.Add(num2);
            for (int i = 2; i < input; i++)
            {
                tempNum = num1 + num2;
                sequence.Add(tempNum);
                num1 = num2;
                num2 = tempNum;
            }
            return sequence;
        }

        public int FindLeastCommonDenominator(int input1, int input2)
        {
            int lcdInt = 0;
            if (input1 < input2)
            {
                for (lcdInt = input1; lcdInt < input1 * input2; lcdInt += input1)
                {
                    if (lcdInt % input1 == 0 && lcdInt % input2 == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (lcdInt = input2; lcdInt < input1 * input2; lcdInt += input2)
                {
                    if (lcdInt % input1 == 0 && lcdInt % input2 == 0)
                    {
                        break;
                    }
                }
            }
            return lcdInt;
        }

        public void FizzBuzz(int input)
        {
            if (input > 0)
            {
                for (int i = 1; i <= input; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i + ": FizzBuzz.");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine(i + ": Fizz.");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine(i + ": Buzz.");
                    }
                }
            }
            else
            {
                for (int i = -1; i >= input; i--)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i + ": FizzBuzz.");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine(i + ": Fizz.");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine(i + ": Buzz.");
                    }
                }
            }
        }

        public Tuple<int, int, bool> LargestPalindromeProduct(int input1, int input2)
        {
            bool isPalindrome = false;
            int num1 = 0;
            int num2 = 0;
            string str = "";
            StringExercises strExercises = new StringExercises();

            for (num1 = input1; num1 > 0; num1--)
            {
                for (num2 = input2; num2 > 0; num2--)
                {
                    str = (num1 * num2).ToString();
                    isPalindrome = strExercises.CheckIsPalindrome(str);
                    if (isPalindrome)
                    {
                        return Tuple.Create(num1, num2, isPalindrome);
                    }
                }
            }

            return Tuple.Create(0, 0, isPalindrome);
        }

        public int LargestPrimeFactor(int input)
        {
            int primeFactor = 0;
            if (input.Equals(1))
            {
                return 1;
            }
            bool isPrime = false;
            for (int i = input/2; i > 0; i--)
            {
                isPrime = true;
                if (input % i == 0)
                {
                    for (int j = 2; j < i/2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime == true)
                    { 
                        primeFactor = i;
                        break;
                    }
                }
            }
            return primeFactor;
        }

        public int MultiplesOf3And5(int input)
        {
            int sum = 0;
            if (input > 0)
            {
                for (int i = 3; i <= input; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = -3; i >= input; i--)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        public List<int> PrimeNumberSieve(int input)
        {
            List<int> primeNumList = new List<int>();
            List<int> tempNumList = new List<int>();
            primeNumList = Enumerable.Range(1, input).ToList();
            foreach (int num in primeNumList.Skip(3))
            {
                for (int i = 2; i < Math.Sqrt(num) + 1; i++)
                {
                    if (num % i == 0)
                    {
                        tempNumList.Add(num);
                        break;
                    }
                }
            }
            primeNumList = primeNumList.Except(tempNumList).ToList();
            return primeNumList;
        }
    }
}
