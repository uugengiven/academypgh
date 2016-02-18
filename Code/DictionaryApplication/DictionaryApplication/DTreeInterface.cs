using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    interface IDictionaryTree
    {
        void addWords(string[] words);
        bool isWord(string word);
        string[] getPossibleWords(string word);
    }
}
