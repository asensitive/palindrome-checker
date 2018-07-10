// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeRepository.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   The palindrome repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// The palindrome repository.
    /// </summary>
    public class PalindromeRepository : IPalindromeRepository
    {
        /// <summary>
        /// The palindrome checker context.
        /// </summary>
        private readonly PalindromeCheckerContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PalindromeRepository"/> class. 
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PalindromeRepository(PalindromeCheckerContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// The get palindrome.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable{T}"/>.
        /// </returns>
        public IEnumerable<Palindrome> GetPalindromes()
        {
            return this.context.Palindrome;
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="palindrome">
        /// The palindrome.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task Add(Palindrome palindrome)
        {
            this.context.Palindrome.Add(palindrome);
            await this.context.SaveChangesAsync();
        }

        /// <summary>
        /// Check if the palindrome exists.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool PalindromeExists(string name)
        {
            return this.context.Palindrome.Any(e => e.Name == name);
        }
    }
}
