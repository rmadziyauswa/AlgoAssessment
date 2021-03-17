using System;
using System.Text;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        private const int START_LENGTH = 4;
        private const int GROUP_COUNT = 3;
        private const int MIN_NUM = 0;
        private const int MAX_NUM = 1000000000;
        public string Format(int value)
        {
            if(value < MIN_NUM || value > MAX_NUM)
            {
                throw new ArgumentOutOfRangeException();
            }
            var stringValue = value.ToString();
            if(stringValue.Length < START_LENGTH)
            {
                return stringValue;
            }
            var sb = new StringBuilder();
            var completeGroups = (int)(stringValue.Length / GROUP_COUNT);
            var mod = stringValue.Length % GROUP_COUNT;
            sb.Append(stringValue.Substring(0, mod));
            for (int i = 0; i < completeGroups; i++)
            {
                var substringIndex = mod + (i * GROUP_COUNT);
                var s = stringValue.Substring(substringIndex, GROUP_COUNT);
                if(i==0 && mod == 0)
                {
                    sb.Append(s);
                    continue;
                }
                sb.Append(",").Append(s);
            }

            return sb.ToString();
        }
    }
}
