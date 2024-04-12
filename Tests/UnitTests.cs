using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(3, Program.Subtract"8", "5"));
            Assert.AreEqual(5, Program.Subtract"10", "5"));
            Assert.AreEqual(12, Program.Subtract("20", "8"));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(3, Program.Multiply("1", "3"));
            Assert.AreEqual(5, Program.Multiply("5", "1"));
            Assert.AreEqual(9, Program.Multiply("3", "3"));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(3, Program.Add("6", "2"));
            Assert.AreEqual(5, Program.Add("15", "3"));
            Assert.AreEqual(2, Program.Add("6", "3"));
        }
        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(36, Program.Power("6", "2"));
            Assert.AreEqual(25, Program.Power("5", "2"));
            Assert.AreEqual(81, Program.Power("9", "2"));
        }
    }
}
