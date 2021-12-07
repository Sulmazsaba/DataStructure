#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashTableSolutions
{
    public class HashTable
    {
        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];
        public void Put(int key, string value)
        {
            var entry = GetEntry(key);
            if (entry != null)
                entry.Value = value;
            
            GetOrCreateBucket(key).AddLast(new Entry()
            {
                Key = key,
                Value = value
            });

        }

        public string? Get(int key) => GetEntry(key)?.Value;
        public void Remove(int key)
        {
            var entry = GetEntry(key);
            if (entry == null)
                throw new InvalidOperationException();

            GetBucket(key).Remove(entry);

        }

        private Entry? GetEntry(int key) => GetBucket(key)?.FirstOrDefault(i => i.Key == key);
        private LinkedList<Entry>? GetBucket(int key) => entries[Hash(key)] ?? null;
        private int Hash(int key) => key % entries.Length;

        private LinkedList<Entry> GetOrCreateBucket(int key)
        {
            var index = Hash(key);
            var bucket = GetBucket(key);
            if (bucket == null)
                entries[index] = new LinkedList<Entry>();

            return bucket??entries[index];
        }
        private class Entry
        {
            public string Value { get; set; }
            public int Key { get; set; }
        }
    }


}
