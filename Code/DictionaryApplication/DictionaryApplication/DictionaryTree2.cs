using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    public class Node
    {
        public char letter;
        Dictionary<char, Node> children;

        public Node(char Letter)
        {
            letter = Letter;
            children = new Dictionary<char, Node>();
        }

        public Node addChild(Node child) {
            children.Add(child.letter, child);
            return child;
        }
    }
    public class DictionaryTreeJean : IDictionaryTree
    {
        Node headNode;
        public DictionaryTreeJean()
        {
            headNode = new Node('a');
        }
        public void addWords(string[] words)
        {
            foreach(string word in words)
            {
                Node currentNode = headNode;
                foreach(char letter in word.ToCharArray())
                {
                    currentNode = currentNode.addChild(new Node(letter));
                }
            }
        }

        public string[] getPossibleWords(string word)
        {
            throw new NotImplementedException();
        }

        public bool isWord(string word)
        {
            return true;
        }
    }
}
