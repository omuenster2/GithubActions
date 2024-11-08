﻿using System;
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
        public void Divide_Valid()
        {
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
            Assert.AreEqual(5, Program.Divide("10", "2"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("4", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "2"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "b"));
        }
        
        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("4", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Divide_ByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Program.Divide("4", "0"));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(16, Program.Power("4", "2"));
            Assert.AreEqual(1, Program.Power("3", "0"));
            Assert.AreEqual(27, Program.Power("3", "3"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("4", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "2"));
            Assert.Throws<FormatException>(() => Program.Power("a", "b"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("4", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(0, Program.Multiply("5", "0"));
            Assert.AreEqual(20, Program.Multiply("4", "5"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("2", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "3"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "b"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-1, Program.Subtract("2", "3"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("3", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "2"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "b"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
    }
}
