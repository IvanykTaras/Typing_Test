using System;
using System.Collections.Generic;

namespace Typing_Test
{
    internal class Program
    {
        static List<Word> words = new List<Word>();





        static void Main(string[] args)
        {

            for (int i = 0; i<10; i++)
	        {
                words.Add((new Word("text")));
                words[i].Same("text");
	        }

            show(words, " ");
            
            

            //Console.WriteLine(new String(inputWord(new List<char>()).ToArray()));
        }


        static void show(List<Word> arr, string separator)
        {
            
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == arr.Count - 1)
                {
                    write(arr[i].Get(), arr[i].GetWordStatus());
                }
                else
                {
                    write(arr[i].Get() + separator, arr[i].GetWordStatus());
                }
            }
        }

        

        static void write(string text, ConsoleColor color = ConsoleColor.White )
        {   Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}