using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public static class StringCalculator
    {
        private static readonly string[] delimeters = { ",", "\n" };
         public static int CalculateString(string s)
        {
            string [] delims = delimeters;
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            

            int[] numbers = s.Split(delims, StringSplitOptions.None).Select(str => Int32.Parse(str)).Where(n => n <= 1000).ToArray();
            //if(numbers.Any(n => n < 0))
            
            return numbers.Sum();
        }

        private static List<string> GetAdditionalDelimeters(string line)
        {
            if (line.ElementAt(2) != '[')
                return new List<string>() { line.Substring(2, 1) };
            return new List<string>() { line[3..^1] };
        }

    }
}
