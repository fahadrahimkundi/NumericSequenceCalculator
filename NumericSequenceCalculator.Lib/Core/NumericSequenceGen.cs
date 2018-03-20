using NumericSequenceCalculator.Lib.Utilities;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Lib.Core
{
    public class NumericSequenceGen
    {   
        public List<int> GetOddNumbers(int number)
        {
            Log4netWrapper.Debug("Odd Number Sequence started for : " + number);

            List<int> numList = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                if (IsOdd(i))
                {
                    numList.Add(i);
                    Log4netWrapper.Debug("Odd Number Sequence for : " + number + " - " + i);
                }
            }

            Log4netWrapper.Debug("Odd Number Sequence finished for : " + number);

            return numList;
        }

        public List<int> GetAllNumbers(int number)
        {
            Log4netWrapper.Debug("Even Number Sequence started for : " + number);

            List<int> numList = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                numList.Add(i);
                Log4netWrapper.Debug("Even Number Sequence for : " + number + " - " + i);
            }

            Log4netWrapper.Debug("Odd Number Sequence finished for : " + number);

            return numList;
        }

        public List<string> GetSpecialCases(int number)
        {
            Log4netWrapper.Debug("Special Cases Sequence started for : " + number);

            List<string> strList = new List<string>();

            for (int i = 0; i <= number; i++)
            {
                if (IsMultipleofThreeAndFive(i))
                {
                    strList.Add("Z");
                }
                else if (IsMultipleofFive(i))
                {
                    strList.Add("E");
                }
                else if (IsMultipleofThree(i))
                {
                    strList.Add("C");
                }
                else
                {
                    strList.Add(i.ToString());
                }
            }

            Log4netWrapper.Debug("Special Cases Sequence finished for : " + number);

            return strList;
        }

        public List<int> GetEvenNumbers(int number)
        {
            List<int> numList = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                if (!IsOdd(i))
                {
                    numList.Add(i);
                }
            }

            return numList;
        }

        private bool IsOdd(int num)
        {
            return !(num % 2 == 0);
        }

        private bool IsMultipleofThree(int num)
        {
            return (num % 3 == 0);
        }

        private bool IsMultipleofFive(int num)
        {
            return (num % 5 == 0);
        }

        private bool IsMultipleofThreeAndFive(int num)
        {
            return (num % 3 == 0 && num % 5 == 0);
        }
    }
}