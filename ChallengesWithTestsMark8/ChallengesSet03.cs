using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsFalse = false;

            foreach (bool value in vals)
            {
                if (value == false)
                {
                    containsFalse = true;
                    break;
                }
            }

            return containsFalse;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
           if (numbers == null)
           { 
               return false;
           } 
           int sumOfOdds = 0;

            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sumOfOdds += number;
                }
               
            }

            return sumOfOdds % 2 != 0;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasNumber = password.Any(Char.IsDigit);
            bool hasLower = password.Any(Char.IsLower);
            bool hasUpper = password.Any(Char.IsUpper);

            return hasNumber && hasLower && hasUpper;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                return ' ';
            }
            else
            {
                return val[0];
            }
        }

        public char GetLastLetterOfString(string val)
        {
         char lastChar = val[^1];
         return lastChar;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return decimal.Divide(dividend, divisor);
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int first = nums[0];
            int last = nums[^1];
            int result = last - first;
            return result;
        }

        public int[] GetOddsBelow100()
        {
            System.Collections.Generic.List<int> oddNumbers = new System.Collections.Generic.List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }
            return oddNumbers.ToArray();
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
