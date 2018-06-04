using System;
using System.Collections.Generic;

namespace Common.Automation.Helpers
{
    public static class RandomHelper
    {
        static Random random = new Random();
        public static List<int> GetRandomNumbers(int count, int rangeFrom, int rangeTo)
        {
            var randomNumbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                var number = 0;
                do
                {
                   number = random.Next(rangeFrom, rangeTo);
                }
                while (randomNumbers.Contains(number));
                randomNumbers.Add(number);
            }

            return randomNumbers;
        }
    }
}
