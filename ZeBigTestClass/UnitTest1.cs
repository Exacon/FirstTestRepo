using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLib;


namespace ZeBigTestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FizzBuzzClass testclass = new FizzBuzzClass();
            Assert.IsNotNull(testclass);
        }

        [TestMethod]
        public void TestMethod2()
        {
            FizzBuzzClass test = new FizzBuzzClass();
            Assert.IsTrue(test.IsFizz(3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            FizzBuzzClass test = new FizzBuzzClass();
            Assert.IsTrue(test.IsBuzz(5));
        }

        [TestMethod]
        public void TestMethod4()
        {
            FizzBuzzClass test = new FizzBuzzClass();
            Assert.IsTrue(test.isFizzBuzz(15));
        }

        [TestMethod]
        public void TestMethod5()
        {
            FizzBuzzClass test = new FizzBuzzClass();
            Assert.IsInstanceOfType(test.runFizzBuzz(),typeof(string));

        }

    }
}
