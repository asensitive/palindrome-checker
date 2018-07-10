// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPalindromeRepository.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the IPalindromeRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Models
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPalindromeRepository
    {
        /// <summary>
        /// The get palindrome.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable{T}"/>.
        /// </returns>
        IEnumerable<Palindrome> GetPalindromes();

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="palindrome">
        /// The palindrome.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task Add(Palindrome palindrome);

        /// <summary>
        /// Check if the palindrome exists.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool PalindromeExists(string name);
    }
}