using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter2.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void GetSetWord_GetsSetsWord_ReturnEqualValue()
        {
            RepeatCounter test = new RepeatCounter("one", "one two three");
            string word = test.GetTheWord();
            Assert.AreEqual(word, "one");
        }

        [TestMethod]
        public void GetSetPhrase_GetsSetsPhrase_ReturnEqualValue()
        {
            RepeatCounter test = new RepeatCounter("one", "one two three");
            string[] phrase = test.GetTheArrayOfWords();
            string testPhrase = "one two three";
            string[] testPhraseArray = testPhrase.Split(' ');
            CollectionAssert.AreEqual(phrase, testPhraseArray);
        }

        [TestMethod]
        public void GetSetTheArrayOfWordsRegardlessOfCase_GetsSetsTheArrayOfWordRegardlessOfCase_True()
        {
            RepeatCounter newGame = new RepeatCounter("test", "Hello nice to meet you");
            string[] NewWords = { "hello", "nice", "to", "meet", "you" };
            CollectionAssert.AreEqual(NewWords, newGame.GetTheArrayOfWords());
        }

        [TestMethod]
        public void GetSetWordsFromArrayDictionary_GetsSetsWordsFromArrayDictionary_True()
        {
            RepeatCounter newGame = new RepeatCounter("hello", "hello nice to meet you");
            Assert.AreEqual(1, newGame.GetWordsFromArrayDictionary()["hello"]);
        }

        [TestMethod]
        public void GetSetWordsFromArrayDictionaryMultiple_GetsSetsWordsFromArrayDictionaryMultiple_True()
        {
            RepeatCounter newGame = new RepeatCounter("test", "hello hello nice to meet you");
            Assert.AreEqual(2, newGame.GetWordsFromArrayDictionary()["hello"]);
        }

        [TestMethod]
        public void GetNumberOfOccurences_GetsNumberOfOccurences_True()
        {
            RepeatCounter newGame = new RepeatCounter("hello", "hello nice to meet you hello");
            Assert.AreEqual(2, newGame.FindTheNumberOfOccurences());
        }

        [TestMethod]
        public void GetNumberOfOccurences_ReturnZeroForNoOccurences_True()
        {
            RepeatCounter newGame = new RepeatCounter("bob", "hello nice to meet you");
            Assert.AreEqual(0, newGame.FindTheNumberOfOccurences());
        }
    }
}
