using ArrayClass.Interfaces;
using System;

namespace ArrayClassLibrary.Activities
{
    public class WordCounter : StringActivity
    {
        private string _text;

        public void SetInput(string input)
        {
            _text = input;
        }

        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(_text))
            {
                Console.WriteLine("No words detected in the input.");
                return;
            }

            string[] wordList = _text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = wordList.Length;

            Console.WriteLine($"Word count: {count}");
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
