using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    public class DictionaryTree : IDictionaryTree
    {
        private static DictionaryTree Missing = new DictionaryTree();

        Dictionary<Char, DictionaryTree> children = new Dictionary<char, DictionaryTree>();
        bool isWordLeaf = false;

        public void addWords(string[] words)
        {
            foreach (var word in words)
            {
                addWord(word);
            }
        }

        public void addWord(String word)
        {
            if (String.IsNullOrEmpty(word)) throw new ArgumentException("Words must not be null or the empty string.");
            var c = word[0];
            if (!children.ContainsKey(c)) children.Add(c, new DictionaryTree());
            if (word.Length == 1) children[c].isWordLeaf = true;
            else children[c].addWord(word.Substring(1));
        }

        public string[] getPossibleWords(string prefix)
        {
            return walk(prefix).collectWords(prefix, new LinkedList<string>()).ToArray();
        }

        private LinkedList<String> collectWords(String prefix, LinkedList<String> accumulator)
        {
            if (isWordLeaf) accumulator.AddLast(prefix);
            foreach (var entry in children)
            {
                entry.Value.collectWords(prefix + entry.Key, accumulator);
            }
            return accumulator;
        }

        public bool isWord(string word)
        {
            return walk(word).isWordLeaf;
        }

        private DictionaryTree walk(String remainder)
        {
            if (String.IsNullOrEmpty(remainder)) return this;
            if (children.ContainsKey(remainder[0])) return children[remainder[0]].walk(remainder.Substring(1));
            else return Missing;
        }
    }
}
