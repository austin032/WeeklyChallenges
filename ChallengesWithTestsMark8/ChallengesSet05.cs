using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return startNumber + (n - (startNumber % n));
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var b in businesses)
            {
                if (b.TotalRevenue == 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            return numbers.SequenceEqual(numbers.OrderBy(x => x));
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            var filtered = words.Select(x => x?.Trim()).Where(x => !string.IsNullOrWhiteSpace(x));
            var sentence = String.Join(" ", filtered);

            if (string.IsNullOrEmpty(sentence))
            {
                return string.Empty;
            }

            return sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return Array.Empty<double>();
            }
            
            var fourthElements = new List<double>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 4 == 0)
                {
                    fourthElements.Add(elements[i]);
                }
            }
            
            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
