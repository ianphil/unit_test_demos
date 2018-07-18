using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSE.Utilities.Tests
{
    [TestClass]
    public class AwesomeUtilities_Tests
    {
        const string LONG_STRING = "Build Epic Stuff";
        const string SHORT_STRING = "Yep";

        [TestMethod]
        public void IsStringLong_Long()
        {
            AwesomeUtilities at = new AwesomeUtilities();
            bool result;

            result = at.IsStringLong(LONG_STRING);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsStringLong_Short()
        {
            AwesomeUtilities at = new AwesomeUtilities();
            bool result;

            result = at.IsStringLong(SHORT_STRING);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsStringLong_Exception()
        {
            AwesomeUtilities at = new AwesomeUtilities();

            at.IsStringLong(null);
        }
    }
}
