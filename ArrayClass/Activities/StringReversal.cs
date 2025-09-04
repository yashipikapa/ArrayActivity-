using ArrayClass.Interfaces;
using System;
using System.Linq;

namespace ArrayClassLibrary.Activities
{
    public class StringReversal : StringActivity
    {
        private string _text;

        public void SetInput(string input)
        {
            _text = input;
        }

        public void Execute()
        {
            Console.WriteLine($"Input: {_text}");

            char[] characters = _text.ToCharArray();
            Array.Reverse(characters);
            string result = new string(characters);

            Console.WriteLine($"Reversed: {result}");
        }

        public void ReverseString()
        {
            throw new NotImplementedException();
        }

        public void CountWords()
        {
            throw new NotImplementedException();
        }

        public void Output()
        {
            throw new NotImplementedException();
        }
    }
}
