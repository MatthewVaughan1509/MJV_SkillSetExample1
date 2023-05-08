using Berkeley2.Implementations;
using Berkeley2.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Berkeley2UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IPalindromeService _stringService;
        public UnitTest1()
        {
            _stringService = new PalindromeService();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_stringService.IsPalindrome("ABBA"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(_stringService.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_stringService.IsPalindrome("A man, a plan, a canal: Bertie"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(_stringService.IsPalindrome(string.Empty));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(_stringService.IsPalindrome(null));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(_stringService.IsPalindrome("CiVic"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(_stringService.IsPalindrome("Sir, I demand, I am a maid named Iris."));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(_stringService.IsPalindrome("Step on no pets!"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(_stringService.IsPalindrome("Eva, can I see bees in a cave?"));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsTrue(_stringService.IsPalindrome(Guid.NewGuid().ToString()));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.IsTrue(_stringService.IsPalindrome("Red roses run no risk, sir, on Nurse’s order."));
        }
    }
}
