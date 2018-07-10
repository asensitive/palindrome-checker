// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// The error.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Error()
        {
            this.ViewData["RequestId"] = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier;
            return this.View();
        }
    }
}
