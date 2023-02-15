using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace roman_numerals_net
{
    public class RomanNumerals
    {
        private static readonly Dictionary<string, int> romanDictionary = new Dictionary<string, int>()
            {
                { "I", 1 }, { "IV", 4 }, { "V", 5 },
                { "IX", 9 }, { "X", 10 }, { "XL", 40 },
                { "L", 50 }, { "XC", 90 }, { "C", 100 },
                { "CD", 400 }, { "D", 500  },
                { "CM", 900 },  { "M", 1000 },
            };

        public static Dictionary<string, int> GetDictionary()
        {
            return romanDictionary;
        }

        public static List<string> GetDictionaryList(bool full = true, bool log = false)
        {
            var dic = full
                ? romanDictionary
                : new Dictionary<string, int>() {
                { "I", 1 },{ "V", 5 },
                { "X", 10 },{ "L", 50 },
                { "C", 100 },{ "D", 500 },
                { "M", 1000 },};

            var lines = dic.Select(e => $"{e.Key} = {e.Value}").ToList();

            if (log)
                Console.WriteLine(string.Join("; ", lines));

            return lines;
        }

        public static (bool success, int number, string errorMessage) ToIntSafe(string romanStr)
        {
            try
            {
                int number = ToInt(romanStr);
                return (true, number, "");
            }
            catch (Exception e)
            {
                //if (e is ArgumentException)
                return (false, -1, $"{e.Message}");
            }
        }

        public static string ToRoman(int number)
        {
            var result = new StringBuilder();

            foreach (var item in romanDictionary.Reverse())
            {
                if (number <= 0) break;
                while (number >= item.Value)
                {
                    result.Append(item.Key);
                    number -= item.Value;
                }
            }
            return result?.ToString() ?? "0";
        }

        public static int ToInt(string romanStr)
        {
            int sum = 0;

            for (int i = 0; i < romanStr.Length; i++)
            {
                string letter = $"{romanStr[i]}";
                int number;

                if (!romanDictionary.TryGetValue($"{letter}", out number))
                {
                    throw new ArgumentException($"The given key '{letter}' is not present in the dictionary");
                }
                if (romanStr.Length > i + 1 && romanDictionary.TryGetValue(($"{letter}{romanStr[i + 1]}"), out int two))
                {
                    sum += two;
                    i++;
                    continue;
                }
                sum += number;
            }
            if (sum < 0) throw new Exception("sum cant be negative! wrong string ");

            return sum;
        }
    }
}