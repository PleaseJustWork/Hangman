// File/Project Prolog
// Name:     Jacob Johnson & Alicia Phurisat
// Period:   A4
// Username: phuriali000
// Project:  
// Date:     4/18/2018 1:37:21 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace ConsoleProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            Console.WriteLine("welcome to Hangman!");
            Console.WriteLine("Push any number from 0 - 9 to choose your word!");

            Console.ReadLine();


            List<string> Wordbank = new List<string> { "food","pinecone","China","left","interior","rat","fur", "supercalifragilisticexpialidocious", "technology","colorado" };

            // Your code goes above here
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
