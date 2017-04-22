using System;
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

        public void ExecuteFunction()
        {
            Console.WriteLine("Enter an integer to choose which method to execute:\n1) FizzBuzz\n2) Check If Number Is Composite");
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
                /*case "3":
                    {
                        List<int> numList = PrimeNumberSieve(GetIntegerInput());
                        if (numList.Count == 0)
                        {
                            Console.WriteLine("There were no prime numbers.");
                        }
                        else
                        {
                            Console.WriteLine("The prime numbers are " + string.Join(", ", numList) + ".");
                        }

                        break;
                    }*/
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
                if (numList.Count != 0)
                {
                    Console.WriteLine(input + " is a composite number. Its factor(s) are " + string.Join(", ", numList) + ".");
                }
                else
                {
                    Console.WriteLine(input + " is not a composite number.");
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

        public List<int> PrimeNumberSieve(int input)
        {
            List<int> primeNumList = new List<int>();
            if (input == 1)
            {
                Console.WriteLine("The prime number is 1.");
                return primeNumList;
            }
            List<int> tempNumList = new List<int>();
            for (int i = 1; i < input; i++)
            {
                primeNumList.Add(i);
                while (i <= (input / 2 + 1))
                {
                    if (input % i == 0)
                    {
                        tempNumList.Add(i);
                    }
                    i++;
                }
            }
            primeNumList = primeNumList.Except(tempNumList).ToList();

            return primeNumList;
        }
    }
}
