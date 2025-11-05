using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            foreach (var val in vals)
            {
                if (val == false)
                {
                  return true;  
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (var number in numbers)
            {
                if(number % 2 != 0)
                {
                    sum += number;
                }
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            
            return false;

            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upper = false;
            var lower = false;
            var number = false;

            foreach (var c in password)
            {
                if (Char.IsUpper(c))
                {
                    upper = true;
                }
                else if (Char.IsLower(c))
                {
                    lower = true;
                }
                else if (Char.IsNumber(c))
                {
                    number = true;
                }
            }
            
            return upper && lower && number;
            
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] -  nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
