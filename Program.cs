using System;
using System.Collections.Generic;

namespace Lab3._3DataStructures2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hello, please enter a few words: ");
            string text = Console.ReadLine();

            Console.WriteLine(ReverseString(text));


        }

        public static string ReverseString(string text)
        {

            //Created a stack of Char
            Stack<char> stack = new Stack<char>();


            //Used foreach loop to push each character in text string to stack.
            foreach (char c in text)
            {
                stack.Push(c);
            }

            //used string.Empty to clear value in text.
            text = string.Empty;

            //Used a while loop to pop each character in the stack back to text string.
            while (stack.Count > 0)
            {
                text += stack.Pop();
            }

            return text;


        }
    }
}
