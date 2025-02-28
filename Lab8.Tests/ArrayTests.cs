using Lab8B2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Tests
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void FindMax()
        {
            int[] array = { 3, 5, 1, 6, 10 };
            int expected = 10;
            int Max = Calculator.FindMax(array);
            Assert.AreEqual(expected, Max);
        }
        [TestMethod]
        public void FindMin()
        {
            int[] array = { 3, 5, 1, 6, 10 };
            int expected = 1;
            int Min = Calculator.FindMin(array);
            Assert.AreEqual(expected, Min);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMinLength0()
        {
            int[] array = { };
            Calculator.FindMin(array);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMinNull()
        {
            int[] array = null;
            Calculator.FindMin(array);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMaxLength0()
        {
            int[] array = { };
            Calculator.FindMax(array);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMaxNull()
        {
            int[] array = null;
            Calculator.FindMax(array);
        }
    }
}
