using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.HashTableSolutions
{
    public static class Problems
    {
        public static string GetNonRepeatedChar(char[] statement)
        {
            var dict = new Dictionary<char, int>();

            foreach (var c in statement)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c] = dict[c] + 1;
                }
            }

            //dict = statement.GroupBy(i => i.ToString()).ToDictionary(g => g.Key, j => j.Count());

            if (dict.ContainsValue(1))
                return dict.FirstOrDefault(i => i.Value == 1).Key.ToString();

            return "Not Found";


        }

        public static HashSet<char> GetSet(char[] statement)
        {
            var set = new HashSet<char>();
            foreach (var c in statement)
            {
                set.Add(c);
            }

            return set;

        }

        public static char? GetFirstRepeatedChar(char[] statement)
        {
            HashSet<char> hashSet = new HashSet<char>();
            foreach (var c in statement)
            {
                if (hashSet.Contains(c))
                    return c;

                hashSet.Add(c);
            }

            return null;
        }
    }
}
