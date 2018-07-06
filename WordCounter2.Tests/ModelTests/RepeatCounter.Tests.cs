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
    }
}
