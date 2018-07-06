// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtension.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the StringExtension type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Models
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The String extension class.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// The check if the string is palindrome.
        /// </summary>
        /// <param name="input">
        /// The input string.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsPalindrome(this string input)
        {
            input = RemoveNonAlphaNumerics(input);
            var reversedInput = ReverseString(input);
            return input == reversedInput;
        }

        /// <summary>
        /// Remove non alpha numeric characters from the input.
        /// </summary>
        /// <param name="input">
        /// The input string.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string RemoveNonAlphaNumerics(string input)
        {
            var rgx = new Regex("[^a-zA-Z0-9]");
            input = rgx.Replace(input, string.Empty).ToLower();
            return input;
        }

        /// <summary>
        /// Reverse the string.
        /// </summary>
        /// <param name="input">
        /// The input string.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversedInput = new string(charArray);
            return reversedInput;
        }
    }
}
