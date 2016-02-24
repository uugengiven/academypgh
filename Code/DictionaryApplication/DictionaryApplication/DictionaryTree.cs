using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    public class DictionaryTree2 : IDictionaryTree
    {
        public void addWords(string[] words)
        {
            foreach (string s in words)
                { addWord(s); }
        }

        public string[] getPossibleWords(string word)
        {
            return head.findPossibleWords(word.ToLower().ToCharArray()).ToArray();
        }

        public bool isWord(string word)
        {
            return head.findWord(word.ToLower().ToCharArray());
        }

        private void addWord(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            if (chars.Length > 0)
            {
                head.add(chars);
            }
        }

        public DictionaryTree2()
        {
            head = new DictionaryNode('!'); // ! is used because chars can't be null
        }

        private DictionaryNode head;
    }

    public class DictionaryNode
    {
        private Dictionary<char, DictionaryNode> nodes;
        private DictionaryNode parent;
        private char character;
        private bool isWord;

        public void add (char[] chars)
        {
            if (!nodes.ContainsKey(chars[0]))
            {
                nodes.Add(chars[0], new DictionaryNode(chars[0], this));
            }
            if (chars.Length > 1)
            {
                nodes[chars[0]].add(chars.Skip(1).ToArray());
            }
            else
            {
                nodes[chars[0]].isWord = true;
            }
        }

        public bool findWord(char[] chars)
        {
            if (nodes.ContainsKey(chars[0]))
            {
                if (chars.Length == 1)
                {
                    return nodes[chars[0]].isWord;
                }
                else
                {
                    return nodes[chars[0]].findWord(chars.Skip(1).ToArray());
                }
            }
            else
            {
                return false;
            }
        }

        public List<string> findPossibleWords(char[] chars, List<string> results = null)
        {
            if (results == null)
                results = new List<string>();

            if (chars.Length > 0)
            {
                if (nodes.ContainsKey(chars[0]))
                {
                    return nodes[chars[0]].findPossibleWords(chars.Skip(1).ToArray(), results);
                }
                else
                {
                    return results;
                }
            }
            else
            {

                if (isWord == true)
                {
                    results.Add(getWord());
                }
                foreach (KeyValuePair<char, DictionaryNode> kvp in nodes)
                {
                    results = kvp.Value.findPossibleWords(new char[] { }, results);
                }
                return results;
            }

        }

        public string getWord()
        {
            if (character == '!')
            {
                return "";
            }
            else
            {
                return parent.getWord() + character.ToString();
            }
        }

        public DictionaryNode(char Character, DictionaryNode Parent = null)
        {
            character = Character;
            parent = Parent;
            nodes = new Dictionary<char, DictionaryNode>();
            isWord = false;
        }
    }
}
