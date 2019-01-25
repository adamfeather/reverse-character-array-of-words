using System;
using System.Collections.Generic;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'o', 'f', ' ', 'l', 'o', 't', ' ', 'a' };

            ReverseArray(array, 0, array.Length - 1);

            Console.WriteLine(new string(array));

            var wordBoundaries = GetWordBoundaries(array);

            foreach (var wordBoundary in wordBoundaries)
            {
                ReverseArray(array, wordBoundary.startOfWord, wordBoundary.endOfWord);
            }

            Console.WriteLine(new string(array));
        }

        private static IEnumerable<(int startOfWord, int endOfWord)> GetWordBoundaries(char[] array)
        {
            int startOfWord = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == ' ')
                {
                    yield return (startOfWord, i - 1);
                    startOfWord = i + 1;
                }
            }

            yield return (startOfWord, array.Length - 1);
        }

        private static void ReverseArray(char[] array, int startIndex, int endIndex)
        {
            int midpoint = (int)Math.Ceiling(((decimal)startIndex + (decimal)endIndex) / 2);

            while (startIndex < midpoint && endIndex >= midpoint)
            {
                var temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;

                startIndex++;
                endIndex--;
            }
        }
    }
}
