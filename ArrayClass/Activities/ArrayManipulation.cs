using ArrayClass.Interfaces;

namespace ArrayClass.Activities
{
    public class ArrayManipulationActivity : ArrayActivity
    {
        private int[] _array;

        public ArrayManipulationActivity(int[] array)
        {
            _array = array;
        }

        public void SetArray(int[] array)
        {
            _array = array;
        }

        public void Output()
        {
            Console.WriteLine("Original array contents:");
            foreach (int number in _array)
            {
                Console.Write($"{number} ");
            }

            int[] reversed = GetReversedArray(_array);

            Console.WriteLine("\nReversed array contents:");
            foreach (int value in reversed)
            {
                Console.Write($"{value} ");
            }
        }

        public void SearchArray(int? target, bool? findLargestValue)
        {
            if (findLargestValue.HasValue && findLargestValue.Value)
            {
                int maxValue = _array.Max();
                Console.WriteLine($"\nMaximum value in the array: {maxValue}");
            }
        }

        private int[] GetReversedArray(int[] source)
        {
            int[] result = new int[source.Length];
            int index = 0;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                result[index++] = source[i];
            }

            return result;
        }
    }
}
