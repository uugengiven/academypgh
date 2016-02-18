using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DictionaryApplication;

namespace DictionaryApplicationTests
{
    [TestClass]
    public class AcceptanceTests
    {
        [TestMethod]
        public void Add_Word_Word_Exists()
        {
            DictionaryTree dict = new DictionaryTree();
           dict.addWords(new string[] { "word" });
            Assert.IsTrue(dict.isWord("word"));
        }

        [TestMethod]
        public void Add_Word_Blah_Does_Not_Exist()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word" });
            Assert.IsFalse(dict.isWord("blah"));
        }

        [TestMethod]
        public void Add_Word_Words_Does_Not_Exist()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word" });
            Assert.IsFalse(dict.isWord("words"));
        }

        [TestMethod]
        public void Add_Word_Wo_Does_Not_Exist()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word" });
            Assert.IsFalse(dict.isWord("wo"));
        }

        [TestMethod]
        public void Add_Multiple_Words_Word_Exists()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word", "words", "john", "joan", "art" });
            Assert.IsTrue(dict.isWord("john"));
        }

        [TestMethod]
        public void Add_Multiple_Words_Secondary_Word_Exists()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word", "words", "john", "joan", "art" });
            Assert.IsTrue(dict.isWord("words"));
        }

        [TestMethod]
        public void Add_Multiple_Words_Word_Does_Not_Exist()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word", "words", "john", "joan", "art" });
            Assert.IsFalse(dict.isWord("henry"));
        }

        [TestMethod]
        public void Add_Multiple_Words_Get_Possible_Results()
        {
            DictionaryTree dict = new DictionaryTree();
            dict.addWords(new string[] { "word", "words", "john", "joan", "art" });
            CollectionAssert.AreEqual(dict.getPossibleWords("wo"), new string[] { "word", "words" });
        }
    }
}
