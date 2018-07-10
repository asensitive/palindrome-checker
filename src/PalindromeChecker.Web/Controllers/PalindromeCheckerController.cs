// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeCheckerController.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the PalindromeCheckerController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using PalindromeChecker.Data;
    using PalindromeChecker.Web.Models;

    /// <summary>
    /// The palindromes controller.
    /// </summary>
    [Produces("application/json")]
    [Route("api/PalindromeChecker")]
    public class PalindromeCheckerController : Controller
    {
        /// <summary>
        /// The palindrome repository.
        /// </summary>
        private readonly IPalindromeRepository palindromeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PalindromeCheckerController"/> class.
        /// </summary>
        /// <param name="palindromeRepository">
        /// The palindrome Repository.
        /// </param>
        public PalindromeCheckerController(IPalindromeRepository palindromeRepository)
        {
            this.palindromeRepository = palindromeRepository;
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
            return this.palindromeRepository.GetPalindromes();
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

            if (this.palindromeRepository.PalindromeExists(palindrome.Name))
            {
                return this.Ok();
            }

            palindrome.DateAdded = DateTime.Now.ToShortDateString();
            await this.palindromeRepository.Add(palindrome);

            return this.CreatedAtAction("GetPalindrome", new { id = palindrome.Id }, palindrome);
        }
    }
}