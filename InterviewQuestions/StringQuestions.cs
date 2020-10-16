using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class StringQuestions
    {
        public static int FirstUniqueChar(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                // Look up character in dictionary
                // If exist, increment count

                var character = s[i];

                if (dictionary.ContainsKey(character))
                {
                    // Increment it
                    dictionary[character] = dictionary[character] + 1;
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }

            int minValue = int.MaxValue;
            int index = 0;
            int result = -1;

            foreach (var item in dictionary)
            {
                if (item.Value < minValue)
                {
                    minValue = item.Value;
                    result = index;
                }
                index++;
            }

            return result;
        }
    }
}