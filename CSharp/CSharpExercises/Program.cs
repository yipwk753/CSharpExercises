using CSharpExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to choose which code to execute:\n1) Integer Exercises\n2) String Exercises");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    {
                        IntegerExercises intExercises = new IntegerExercises();
                        intExercises.ExecuteFunction();
                        break;
                    }
                case "2":
                    {
                        StringExercises strExercises = new StringExercises();
                        strExercises.ExecuteFunction();
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}