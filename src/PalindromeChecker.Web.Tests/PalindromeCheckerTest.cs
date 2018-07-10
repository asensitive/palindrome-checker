// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeCheckerTest.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   The palindrome checker test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using PalindromeChecker.Web.Models;

    /// <summary>
    /// The palindrome checker test.
    /// </summary>
    [TestClass]
    public class PalindromeCheckerTest
    {
        /// <summary>
        /// The check.
        /// </summary>
        [TestMethod]
        public void StringIsPalindrome()
        {
            var inputString = "Radar";
            var isPalindrome = inputString.IsPalindrome();
            Assert.IsTrue(isPalindrome);
        }

        /// <summary>
        /// The string is not palindrome.
        /// </summary>
        [TestMethod]
        public void StringIsNotPalindrome()
        {
            var inputString = "Hello";
            var isPalindrome = inputString.IsPalindrome();
            Assert.IsFalse(isPalindrome);
        }
    }
}

