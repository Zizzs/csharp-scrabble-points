using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleGame
{
    public class Program
    {
        public static void Main()
        {
            Scrabble main = new Scrabble();
            int totalCount = 0;
            Console.WriteLine("Please type a word to convert to SCRABBLE POINTS!");
            string userInput = (Console.ReadLine()).ToUpper();
            char[] userArray = userInput.ToCharArray();

            foreach (char letter in userArray)
            {
               totalCount = totalCount + main.scrabblePoints(letter);
            }

            Console.WriteLine("Your Scrabble Score is: " + totalCount);
        }
    }

    public class Scrabble
    {
        public int scrabblePoints(char letter)
        {
            if ("AEIOULNRST".Contains(letter))
            {
                return 1;
            }
            else if ("DG".Contains(letter))
            {
                return 2;
            }
            else if ("BCMP".Contains(letter))
            {
                return 3;
            }
            else if ("FHVWY".Contains(letter))
            {
                return 4;
            }
            else if ("K".Contains(letter))
            {
                return 5;
            }
            else if ("JX".Contains(letter))
            {
                return 8;
            }
            else if("QZ".Contains(letter))
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
    }
}
