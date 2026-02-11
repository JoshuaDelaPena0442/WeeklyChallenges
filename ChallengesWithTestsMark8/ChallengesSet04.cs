using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minOne = Math.Min(str1.Length, str2.Length);
            int minTwo = Math.Min(str3.Length, str4.Length);
            
            return Math.Min(minOne, minTwo);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz.Name != "TrueCoders")
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            int nullCount = 0;
            int nullMajority = (objs.Length / 2) + 1;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }

                if (nullCount >= nullMajority)
                {
                    return true;
                }
            }

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(x => x % 2 == 0);

            if (!evens.Any())
            {
                return 0;
            }

            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }

        }
    }
}
