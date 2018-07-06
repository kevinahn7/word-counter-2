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
    }
}
