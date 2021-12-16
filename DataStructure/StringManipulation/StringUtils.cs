using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.StringManipulation
{
    public class StringUtils
    {
        public static int CountVowels(string str)
        {
            var vowels = "aioue";

            return str.ToLower().ToCharArray().Count(c => vowels.Contains(c));

        }

        public static string Reverse(string str) => String.Join("", str.Reverse());

        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            
            return string.Join(" ", words.Reverse());
        }

        public static bool IsRotated(string first, string second) =>
            (first.Length == second.Length) && (first+first).Contains(second);

        public static void RemoveDuplicateChar(ref string word)
        {
            var result = "";
            foreach (var c in word.ToCharArray())
            {
                if (!result.Contains(c))
                    result += c;
            }

            word = result;
        }

        public static char GetMostRepeatedChar(string word)
        {
            var dictionary = new SortedDictionary<char, int>();

            foreach (var c in word.ToCharArray())
            {
                if (dictionary.ContainsKey(c))
                    dictionary[c]++;
                else
                    dictionary[c] = 1;
            }

            return dictionary.OrderByDescending(i=>i.Value).First().Key;
        }
    }
}
