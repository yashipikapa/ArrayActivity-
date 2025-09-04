using ArrayClass.Interfaces;
using System;
using System.Linq;

namespace ArrayClassLibrary.Activities
{
    public class ArrayManipulation : ArrayActivity
    {
        private int[] _data;

        public ArrayManipulation(int[] array)
        {
            _data = array;
        }

        public void SetArray(int[] array)
        {
            _data = array;
        }

        public void Output()
        {
            Console.WriteLine("Current array values:");
            foreach (int value in _data)
            {
                Console.Write($"{value} ");
            }

            int[] flipped = Reverse(_data);

            Console.WriteLine("\nArray in reverse order:");
            foreach (int value in flipped)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }

        public void SearchArray(int? target, bool? findMax)
        {
            if (findMax.HasValue && findMax.Value)
            {
                int max = _data.Max();
                Console.WriteLine($"Maximum value found: {max}");
            }
            else if (target.HasValue)
            {
                int foundIndex = -1;
                for (int i = 0; i < _data.Length; i++)
                {
                    if (_data[i] == target.Value)
                    {
                        foundIndex = i;
                        break;
                    }
                }

                if (foundIndex != -1)
                    Console.WriteLine($"Target {target.Value} located at index {foundIndex}.");
                else
                    Console.WriteLine($"Target {target.Value} not present in the array.");
            }
            else
            {
                Console.WriteLine("Search failed: no valid input provided.");
            }
        }

        private int[] Reverse(int[] source)
        {
            int[] reversed = new int[source.Length];
            int position = 0;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                reversed[position++] = source[i];
            }

            return reversed;
        }
    }
}
