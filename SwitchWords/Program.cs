using System;

namespace SwitchWords
   {
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Rotatetext");
            Console.WriteLine("2. Change word");

            string userInput = Console.ReadLine();


            if (userInput == "1")
                Console.WriteLine("Write the word you want to rotate");
            else if (userInput == "2")
                Console.WriteLine("Write the word you want to change");

        }
    }
   }