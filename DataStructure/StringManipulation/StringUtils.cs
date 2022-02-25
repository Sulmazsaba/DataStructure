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

        public static bool IsRotated(string first, string second) => (first.Length == second.Length) && (first + first.Reverse()).Contains(second);

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

            return dictionary.OrderByDescending(i => i.Value).First().Key;
        }

        public static string Capitalize(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return "";


            var words = sentence.Trim().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            return string.Join(" ", words);
        }

        public static bool AreAnagrams(string value1,string value2)
        {
            var array1 = value1.ToLower().ToCharArray();
            Array.Sort(array1);
            var array2 = value2.ToLower().ToCharArray();
            Array.Sort(array2);

            return array1.SequenceEqual(array2);

        }

        public static bool ArePalindrome(string value) => value == String.Join("", value.Reverse());
        
    }
}
