using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Typing_Test
{
    public class Word
    {
        private string word;


        private static (ConsoleColor Wrong, ConsoleColor Correct, ConsoleColor UnChanged) WordStatus = (
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.White
        );

        private ConsoleColor status = WordStatus.UnChanged;

        public Word(string input) { 
            word = input;
        }

        public string Get() {
            return word;
        }
        public void Set(string value)
        {
            word = value;
        }

        public ConsoleColor GetWordStatus() => status;

        public void Same(string input)
        {
            status = input == word ? WordStatus.Correct : WordStatus.Wrong;
        }
    }

    

}
