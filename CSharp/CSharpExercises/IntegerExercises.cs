using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public struct GridDetails
    {
        public int[] GridTempValues;
        public int[] GridValues;
        public long Product;
        public string Direction;
        public string[] GridIndexes;
        public string[] GridTempIndexes;
    }

    public class IntegerExercises
    {
        #region Helper Methods
        static void AlterGridDetails(ref GridDetails gridDetails, int adjacentNumbers, ref long product, long tempProduct, string direction)
        {
            product = tempProduct;
            Array.Copy(gridDetails.GridTempIndexes, gridDetails.GridIndexes, adjacentNumbers);
            Array.Copy(gridDetails.GridTempValues, gridDetails.GridValues, adjacentNumbers);
            gridDetails.Product = product;
            gridDetails.Direction = direction;
        }

        public static int[,] GenerateGrid()
        {
            Console.WriteLine("Enter a non-zero whole number.");
            int arrayLeftInit = 0;
            Int32.TryParse(Console.ReadLine(), out arrayLeftInit);

            Console.WriteLine("Enter a non-zero whole number.");
            int arrayRightInit = 0;
            Int32.TryParse(Console.ReadLine(), out arrayRightInit);
            if (arrayLeftInit == 0 || arrayRightInit == 0)
            {
                Console.WriteLine("For one or both inputs, you did not enter a number, you entered a zero, or you entered a number " +
                    "with a decimal.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            int[,] grid = new int[arrayLeftInit, arrayRightInit];
            Random rand = new Random();
            for(int j = 0; j < arrayLeftInit; j++)
            {
                for(int k = 0; k < arrayRightInit; k++)
                {
                    grid[arrayLeftInit, arrayRightInit] = rand.Next(0, 99);
                }
            }
            return grid;
        }

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

        public static string GetIntegerStringInput()
        {
            Console.WriteLine("Enter a series of numbers.");
            string response = Console.ReadLine();

            return response;
        }

        public static int GetPositiveIntegerInput()
        {
            Console.WriteLine("Enter a non-zero positive whole number.");
            int response = 0;
            Int32.TryParse(Console.ReadLine(), out response);
            if (response <= 0)
            {
                Console.WriteLine("You did not enter a number, you entered a zero, you entered a negative number, you entered a number " +
                    "with a decimal, or you entered a number that exceeded the max possible value.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return response;
        }

        public static long GetPositiveLongInput()
        {
            Console.WriteLine("Enter a non-zero positive whole number.");
            long response = 0;
            long.TryParse(Console.ReadLine(), out response);
            if (response <= 0)
            {
                Console.WriteLine("You did not enter a number, you entered a zero, you entered a negative number, you entered a number " +
                    "with a decimal, or you entered a number that exceeded the max possible value.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return response;
        }

        public void ExecuteFunction()
        {
            Console.WriteLine("Enter an integer to choose which method to execute:\n1) FizzBuzz\n2) Get Factors Of Composite Number\n3) Find LCD Of Two Numbers" +
                "\n4) Prime Number Sieve\n5) Fibonacci Sequence\n6) Multiples of 3 and 5\n7) Even Fibonacci Numbers Sum\n8) Largest Prime Factor\n9) Largest Palindrome Product"+
                "\n10) Smallest Multiple\n11) Sum Square Difference\n12) Check If Number Is Composite\n13) Find N-Prime\n14) Largest Product In Series\n15) Find Pythagorean Triplet"+
                "\n16)Summation Of Primes\n17) Largest Product In A Grid");
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
                        List<int> numList = GetFactorsOfCompositeNumber(input);
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
                case "10":
                    {
                        int smallestMultiple = SmallestMultiple(GetPositiveIntegerInput());
                        if (smallestMultiple > 0)
                        {
                            Console.WriteLine("The smallest multiple is {0}.", smallestMultiple);
                        }
                        else
                        {
                            Console.WriteLine("There is no smallest multiple.");
                        }
                        break;
                    }
                case "11":
                    {
                        int input = GetPositiveIntegerInput();
                        long difference = SumSquareDifferences(input);
                        if (difference < 0)
                        {
                            Console.WriteLine("The number you entered exceeded the max possible value.");
                        }
                        else
                        { 
                            Console.WriteLine("The difference computed from the input {0} is {1}.", input, difference);
                        }
                        break;
                    }
                case "12":
                    {
                        int input = GetIntegerInput();
                        bool isComposite = CheckIfNumberIsComposite(input);
                        if (isComposite)
                        {
                            Console.WriteLine("The number {0} is composite.", input);
                        }
                        else
                        {
                            Console.WriteLine("The number {0} is not composite.", input);
                        }
                        break;
                    }
                case "13":
                    {
                        int input = GetIntegerInput();
                        int primeNum = FindNPrime(input);
                        Console.WriteLine("The {0}st/th prime number is {1}.", input, primeNum);
                        break;
                    }
                case "14":
                    {
                        string numSeries = GetIntegerStringInput();
                        int numOfAdjacentDigits = GetPositiveIntegerInput();
                        long product = LargestProductInSeries(numSeries, numOfAdjacentDigits);
                        if (product < 0)
                        {
                            Console.WriteLine("Either the second number you entered is larger than the length of the series of numbers you entered or the "
                                + "product exceeded the max possible value.");
                        }
                        else
                        { 
                            Console.WriteLine("The largest product in the series derived from {0} adjacent digits is {1}.", numOfAdjacentDigits, product);
                        }
                        break;
                    }
                case "15":
                    {
                        int input = GetPositiveIntegerInput();
                        var pythagoreanTriplet = FindPythagoreanTriplet(input);
                        if (pythagoreanTriplet.Item5)
                        {
                            Console.WriteLine("Your input produced the pythagorean triplet of a: {0}, b: {1}, and c: {2} with a product of {3}", 
                                pythagoreanTriplet.Item1, pythagoreanTriplet.Item2, pythagoreanTriplet.Item3, pythagoreanTriplet.Item4);
                        }
                        else
                        {
                            Console.WriteLine("Your input did not produce a pythagorean triplet.");
                        }
                        break;
                    }
                case "16":
                    {
                        int input = GetPositiveIntegerInput();
                        long sum = SummationOfPrimes(input);
                        Console.WriteLine("The sum of the primes derived from the input {0} is {1}.", input, sum);
                        break;
                    }
                case "17":
                    {
                        int[,] grid = GenerateGrid();
                        int adjacentNumbers = GetPositiveIntegerInput();
                        GridDetails gridDetails = LargestProductInAGrid(grid, adjacentNumbers);
                        Console.WriteLine("The largest product in the grid is " + gridDetails.Product);
                        Console.WriteLine("The direction used to derive the largest product is " + gridDetails.Direction);
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

        public bool CheckIfNumberIsComposite(int input)
        {
            bool isComposite = false;
            if (input > 0)
            {
                for (int i = 2; i < (input / 2 + 1); i++)
                {
                    if (input % i == 0)
                    {
                        isComposite = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = -2; i > (input / 2 - 1); i--)
                {
                    if (input % i == 0)
                    {
                        isComposite = true;
                        break;
                    }
                }
            }
            return isComposite;
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

        public int FindNPrime(int input)
        {
            bool isComposite = false;
            int primeNum = 0, primeNumCounter = 0, incrementor = 2;
            while (primeNumCounter < input)
            {
                isComposite = CheckIfNumberIsComposite(incrementor);
                if (!isComposite)
                {
                    primeNum = incrementor;
                    primeNumCounter++;
                }
                incrementor++;
            }

            return primeNum;
        }

        public Tuple<int, int, int, int, bool> FindPythagoreanTriplet(int input)
        {
            bool isPerfectSquare = false;
            double square = 0;
            int aSide = 0, bSide = 1, cSide = 0, product = 0;
            for (aSide = 2; aSide + bSide + cSide <= input; aSide++)
            {
                for (bSide = aSide + 1; aSide + bSide + cSide <= input; bSide++)
                {
                    square = Math.Sqrt(aSide * aSide + bSide * bSide);
                    if ((int)Math.Ceiling(square) == (int)Math.Floor(square))
                    {
                        cSide = (int)square;

                        if (aSide + bSide + cSide == input)
                        {
                            product = aSide * bSide * cSide;
                            isPerfectSquare = true;
                            return Tuple.Create(aSide, bSide, cSide, product, isPerfectSquare);
                        }
                    }
                }
                bSide = aSide + 1;
            }

            return Tuple.Create(0, 0, 0, 0, isPerfectSquare);
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

        public List<int> GetFactorsOfCompositeNumber(int input)
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

        public GridDetails LargestProductInAGrid(int[,] grid, int adjacentNumbers)
        {
            int arrayLeftLength = grid.GetLength(0);
            int arrayRightLength = grid.GetLength(1);
            if (adjacentNumbers > arrayLeftLength && adjacentNumbers > arrayRightLength)
            {
                Console.WriteLine("The adjacent number is greater than the bounds of the array.");
                Environment.Exit(0);
            }

            long product = 0;
            long tempProduct = 1;

            GridDetails gridDetails = new GridDetails();
            if (arrayLeftLength == 1 && arrayRightLength == 1)
            {
                gridDetails.Direction = "None";
                gridDetails.Product = grid[0, 0];
                gridDetails.GridIndexes = new string[1];
                gridDetails.GridIndexes[0] = "[" + 0 + "," + 0 + "]";
                gridDetails.GridValues = new int[1];
                gridDetails.GridValues[0] = grid[0, 0];
                return gridDetails;
            }

            gridDetails.GridIndexes = new string[adjacentNumbers];
            gridDetails.GridTempValues = new int[adjacentNumbers];
            gridDetails.GridTempIndexes = new string[adjacentNumbers];
            gridDetails.GridValues = new int[adjacentNumbers];

            if (arrayRightLength > 1 && arrayRightLength > adjacentNumbers)
            {
                //left to right starting from top to bottom
                for (int leftIndex = 0; leftIndex < arrayLeftLength; leftIndex++)
                {
                    int tempRightLength = 0;
                    while (tempRightLength <= arrayRightLength - adjacentNumbers)
                    {
                        tempProduct = 1;
                        for (int rightIndex = tempRightLength, iterator = 0; iterator < adjacentNumbers; rightIndex++, iterator++)
                        {
                            tempProduct *= grid[leftIndex, rightIndex];
                            gridDetails.GridTempIndexes[iterator] = "[" + leftIndex + "," + rightIndex + "]";
                            gridDetails.GridTempValues[iterator] = grid[leftIndex, rightIndex];
                        }
                        if (tempProduct > product)
                        {
                            AlterGridDetails(ref gridDetails, adjacentNumbers, ref product, tempProduct, "Horizontal");
                        }
                        Array.Clear(gridDetails.GridTempIndexes, 0, gridDetails.GridTempIndexes.Length);
                        Array.Clear(gridDetails.GridTempValues, 0, gridDetails.GridTempValues.Length);
                        tempRightLength++;
                    }
                }
            }
            if (arrayLeftLength > 1 && arrayLeftLength > adjacentNumbers)
            {
                //top to bottom starting from left to right
                for (int rightIndex = 0; rightIndex < arrayRightLength; rightIndex++)
                {
                    int tempLeftLength = 0;
                    while (tempLeftLength <= arrayLeftLength - adjacentNumbers)
                    {
                        tempProduct = 1;
                        for (int leftIndex = tempLeftLength, iterator = 0; iterator < adjacentNumbers; leftIndex++, iterator++)
                        {
                            tempProduct *= grid[leftIndex, rightIndex];
                            gridDetails.GridTempIndexes[iterator] = "[" + leftIndex + "," + rightIndex + "]";
                            gridDetails.GridTempValues[iterator] = grid[leftIndex, rightIndex];
                        }
                        if (tempProduct > product)
                        {
                            AlterGridDetails(ref gridDetails, adjacentNumbers, ref product, tempProduct, "Vertical");
                        }
                        Array.Clear(gridDetails.GridTempIndexes, 0, gridDetails.GridTempIndexes.Length);
                        Array.Clear(gridDetails.GridTempValues, 0, gridDetails.GridTempValues.Length);
                        tempLeftLength++;
                    }
                }
            }
            if (arrayLeftLength > 1 && arrayRightLength > 1)
            {
                //diagonal left to right starting from top to bottom
                for (int leftIndex = 0; leftIndex <= arrayLeftLength - adjacentNumbers; leftIndex++)
                {
                    int tempRightindex = 0;
                    while (tempRightindex <= arrayRightLength - adjacentNumbers)
                    {
                        tempProduct = 1;
                        for (int rightIndex = tempRightindex, iterator = 0; iterator < adjacentNumbers; rightIndex++, iterator++)
                        {
                            tempProduct *= grid[leftIndex + iterator, rightIndex];
                            gridDetails.GridTempIndexes[iterator] = "[" + (leftIndex + iterator) + "," + rightIndex + "]";
                            gridDetails.GridTempValues[iterator] = grid[leftIndex + iterator, rightIndex];
                        }
                        if (tempProduct > product)
                        {
                            AlterGridDetails(ref gridDetails, adjacentNumbers, ref product, tempProduct, "Left-to-right diagonal");
                        }
                        Array.Clear(gridDetails.GridTempIndexes, 0, gridDetails.GridTempIndexes.Length);
                        Array.Clear(gridDetails.GridTempValues, 0, gridDetails.GridTempValues.Length);
                        tempRightindex++;
                    }
                }
                //diagonal right to left starting from top to bottom
                for (int leftIndex = 0; leftIndex <= arrayLeftLength - adjacentNumbers; leftIndex++)
                {
                    int tempRightIndex = arrayRightLength - 1;
                    while (tempRightIndex >= adjacentNumbers - 1)
                    {
                        tempProduct = 1;
                        for (int rightIndex = tempRightIndex, iterator = 0; iterator < adjacentNumbers; rightIndex--, iterator++)
                        {
                            tempProduct *= grid[leftIndex + iterator, rightIndex];
                            gridDetails.GridTempIndexes[iterator] = "[" + (leftIndex + iterator) + "," + rightIndex + "]";
                            gridDetails.GridTempValues[iterator] = grid[leftIndex + iterator, rightIndex];
                        }
                        if (tempProduct > product)
                        {
                            AlterGridDetails(ref gridDetails, adjacentNumbers, ref product, tempProduct, "Right-to-left diagonal");
                        }
                        Array.Clear(gridDetails.GridTempIndexes, 0, gridDetails.GridTempIndexes.Length);
                        Array.Clear(gridDetails.GridTempValues, 0, gridDetails.GridTempValues.Length);
                        tempRightIndex--;
                    }
                }
            }

            return gridDetails;
        }

        public long LargestProductInSeries(string numSeries, int numOfAdjacentDigits)
        {
            if (numOfAdjacentDigits > numSeries.Length)
            {
                return -1;
            }
            long product = 0, tempProduct = 0;
            int stringCount = numSeries.Length;
            int[] numArray = new int[stringCount];
            for (int i = 0; i < stringCount; i++)
            {
                numArray[i] = (int)Char.GetNumericValue(numSeries[i]);
            }
            for (int i = 0; i < stringCount - numOfAdjacentDigits + 1; i++)
            {
                tempProduct = 1;
                for (int j = 0; j < numOfAdjacentDigits; j++)
                {
                    tempProduct *= numArray[i + j];
                }
                if (tempProduct > product)
                {
                    product = tempProduct;
                }
            }
            return product;
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

        public int SmallestMultiple(int input)
        {
            bool isDivisible;
            int smallestMultiple = 0;
            for (int i = input; i < int.MaxValue; i++)
            {
                isDivisible = true;
                for (int j = input; j > 0; j--)
                {
                    if (i % j != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    smallestMultiple = i;
                    return smallestMultiple;
                }
            }
            return smallestMultiple;
        }

        //this runs very slowly for large inputs, implement a better algorithm in the future
        public long SummationOfPrimes(int input)
        {
            long sum = 0;
            for (int j = 2; j <= input; j++)
            {
                bool isComposite = CheckIfNumberIsComposite(j);
                if (!isComposite)
                {
                    sum += j;
                }
            }
            return sum;
        }

        public long SumSquareDifferences(int input)
        {
            long difference = 0;
            long squareOfTheSum = 0;
            long sumOfTheSquares = 0;
            for (int i = 1; i <= input; i++)
            {
                squareOfTheSum += i;
                sumOfTheSquares += (i * i);
            }
            squareOfTheSum = squareOfTheSum * squareOfTheSum;
            difference = squareOfTheSum - sumOfTheSquares;

            return difference;
        }
    }
}
