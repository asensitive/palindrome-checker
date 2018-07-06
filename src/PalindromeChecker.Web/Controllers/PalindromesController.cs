// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromesController.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the PalindromesController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using PalindromeChecker.Web.Data;
    using PalindromeChecker.Web.Models;

    /// <summary>
    /// The palindromes controller.
    /// </summary>
    [Produces("application/json")]
    [Route("api/Palindromes")]
    public class PalindromesController : Controller
    {
        /// <summary>
        /// The palindrome checker context.
        /// </summary>
        private readonly PalindromeCheckerContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PalindromesController"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PalindromesController(PalindromeCheckerContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// GET: API/Palindromes
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable{T}"/>.
        /// </returns>
        [HttpGet]
        public IEnumerable<Palindrome> GetPalindrome()
        {
            return this.context.Palindrome;
        }

        /// <summary>
        /// POST: API/Palindromes
        /// </summary>
        /// <param name="palindrome">
        /// The palindrome.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [HttpPost]
        public async Task<IActionResult> PostPalindrome([FromBody] Palindrome palindrome)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (!palindrome.Name.IsPalindrome())
            {
                return this.BadRequest();
            }

            if (this.PalindromeExists(palindrome.Name))
            {
                return this.Ok();
            }

            palindrome.DateAdded = DateTime.Now.ToShortDateString();
            this.context.Palindrome.Add(palindrome);
            await this.context.SaveChangesAsync();

            return this.CreatedAtAction("GetPalindrome", new { id = palindrome.Id }, palindrome);
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
        private bool PalindromeExists(string name)
        {
            return this.context.Palindrome.Any(e => e.Name == name);
        }
    }
}