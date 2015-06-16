using System;
using System.Collections.Generic;

namespace ProgrammingChallenges.Challenges
{
    /// <summary>
    /// Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
    /// </summary>
    public sealed class FizzBuzz
    {
        private string FizzBuzzString(uint Count = 100)
        {
            string str = String.Empty;
            for(uint i=1; i<=Count; i++)
            {
                bool three = (i % 3 == 0);
                bool five = (i % 5 == 0);
    
                str += ((three ? "Fizz" : "") + (five ? "Buzz" : "") + (!three && !five ? i.ToString() : "")) + "\n";
            }
            return str;
        }

        public static void RunAll()
        {
            Console.WriteLine("FizzBuzz counting to 100:");
            Console.Write(new FizzBuzz().FizzBuzzString(100));
        }
    }
}
