using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            
            var containsWord = false;

            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }

            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }
            
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }

            if (num % 2 == 0)
            {
                return false;
            }
            
            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            
            return  true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var charCounts = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCounts[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            if (elements == null || n < 0)
            {
                return [];
            }
            var newList = new List<double>();

            foreach (var x in elements)
            {
                if (x % n == 0)
                {
                    newList.Add(x);
                }
            }

            return newList.ToArray();
        }
    }
}
