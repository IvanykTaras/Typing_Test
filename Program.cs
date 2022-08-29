using System;
using System.Collections.Generic;

namespace Typing_Test
{
    internal class Program
    {
        static List<(string word, bool correct)> words = new List<(string word, bool correct)> ();
        

        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                words.Add(("word",true));
            } 

           
            
            //Console.WriteLine(new String(inputWord(new List<char>()).ToArray()));
        }

        static List<char> inputWord(List<char> c)
        {
            char letter = Console.ReadKey().KeyChar;
            if (letter != ' ' && char.IsLetter(letter))
            {
                c.Add(letter);
                return inputWord(c);
            }
            else {
                return c;
            }
            
        }


        static void write(string text, ConsoleColor color = ConsoleColor.White )
        {   Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}