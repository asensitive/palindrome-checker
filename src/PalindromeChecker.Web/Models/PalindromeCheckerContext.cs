// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeCheckerContext.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the PalindromeCheckerContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Models
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The palindrome checker context.
    /// </summary>
    public class PalindromeCheckerContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PalindromeCheckerContext"/> class.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public PalindromeCheckerContext(DbContextOptions<PalindromeCheckerContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the palindrome.
        /// </summary>
        public DbSet<Palindrome> Palindrome { get; set; }
    }
}
