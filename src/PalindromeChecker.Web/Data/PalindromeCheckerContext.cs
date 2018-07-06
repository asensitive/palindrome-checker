namespace PalindromeChecker.Web.Data
{
    using Microsoft.EntityFrameworkCore;

    using PalindromeChecker.Web.Models;

    public class PalindromeCheckerContext : DbContext
    {
        public PalindromeCheckerContext (DbContextOptions<PalindromeCheckerContext> options)
            : base(options)
        {
        }

        public DbSet<Palindrome> Palindrome { get; set; }
    }
}
