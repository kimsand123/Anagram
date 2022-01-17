using Anagram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramTestProject
{
    [TestClass]
    public class TestAnaGrams
    {
        private StringLogic _stringHandler = new();

        [TestMethod]
        public void PositiveTests()
        {
            bool result = false;
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Clint Eastwood"), _stringHandler.cleanString("old west action"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Elvis Presley"), _stringHandler.cleanString("Presley lives"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Emily Dickinson"), _stringHandler.cleanString("income is kindly"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("George Bush"), _stringHandler.cleanString("he bugs Gore"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Jim Morrison"), _stringHandler.cleanString("Mr. Mojo Risin'"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Madonna Louise Ciccone"), _stringHandler.cleanString("one cool dance musician"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Michael Jordan"), _stringHandler.cleanString("jam on, rich deal"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Ronald Reagan"), _stringHandler.cleanString("A darn long era"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Russell Crowe"), _stringHandler.cleanString("scowler rules"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Saoirse Ronan"), _stringHandler.cleanString("rare as onions"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Shaquille O'Neal"), _stringHandler.cleanString("one equals a hill"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Thomas Edison"), _stringHandler.cleanString("notes said \"Ohm\""));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("T.S. Eliot"), _stringHandler.cleanString("toilets"));
            Assert.AreEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("William Shakespeare"), _stringHandler.cleanString("I'll make a wise phrase"));
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void NegativeTests()
        {
            bool result = false;
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Clint Eastwood"), _stringHandler.cleanString("old west actio"));
            Assert.AreNotEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("Willaam Shakespeare"), _stringHandler.cleanString("I'll make a wise phrase"));
            Assert.AreNotEqual(true, result);
            result = _stringHandler.compareStrings(_stringHandler.cleanString("William Shakespearee"), _stringHandler.cleanString("I'll make a wise phrase"));
            Assert.AreNotEqual(true, result);
        }

    }
}
