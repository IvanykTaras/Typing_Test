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

            string inputWord = "";
            while(!inputWord.Contains(' '))
            {
                Console.Clear ();
                string correctWord = words[0].word;
                show(words, ", ");
                write("\n" + inputWord);

                
                char letter = Console.ReadKey().KeyChar;
                inputWord += letter;
                for (int j = 0; j < inputWord.Length; j++)
                {
                    try
                    {
                        if (inputWord[j] != correctWord[j])
                        {
                            words[0] = (words[0].word, false);
                        }
                        else {
                            words[0] = (words[0].word, true);
                        }

                    }
                    catch (Exception e)
                    {
                    }
                }
            }



            show(words, ", ");
           
            
            //Console.WriteLine(new String(inputWord(new List<char>()).ToArray()));
        }


        static void show(List<(string,bool)> arr, string separator)
        {
            foreach (var item in arr)
            {
                write(item.Item1 + separator, item.Item2 ? ConsoleColor.White : ConsoleColor.Red);
            }
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