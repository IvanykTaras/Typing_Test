using System;

namespace Typing_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new String(inputWord(new List<char>()).ToArray()));
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
    }
}