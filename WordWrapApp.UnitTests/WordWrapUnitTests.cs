using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using wordWrapApp.Core;

namespace WordWrapApp.UnitTests
{
    [TestClass]
    public class WordWrapUnitTests
    {
        [TestMethod]
        [DataRow("ab cdef gh ij", 3, DisplayName = "Functional Case - Without extra spaces")]
        public void WrapTestCase1(string inputString, int columnWidth)
        {
            string testResult = WordWrap.Wrap(inputString, columnWidth);
            Assert.IsInstanceOfType(testResult, typeof(string));
            Assert.AreEqual(testResult, "ab\ncde\nf\ngh\nij\n");
        }

        [TestMethod]
        [DataRow("    ab    cdef    gh   ij      ", 3, DisplayName = "Functional Case - With extra spaces")]
        public void WrapTestCase2(string inputString, int columnWidth)
        {
            string testResult = WordWrap.Wrap(inputString, columnWidth);
            Assert.IsInstanceOfType(testResult, typeof(string));
            Assert.AreEqual(testResult, "ab\ncde\nf\ngh\nij\n");
        }
    }
}
