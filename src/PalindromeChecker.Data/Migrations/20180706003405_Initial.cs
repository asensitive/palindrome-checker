// --------------------------------------------------------------------------------------------------------------------
// <copyright file="20180706003405_Initial.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the Initial type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PalindromeChecker.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;

    /// <summary>
    /// The initial.
    /// </summary>
    public partial class Initial : Migration
    {
        /// <summary>
        /// The up.
        /// </summary>
        /// <param name="migrationBuilder">
        /// The migration builder.
        /// </param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Palindrome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palindrome", x => x.Id);
                });
        }

        /// <summary>
        /// The down.
        /// </summary>
        /// <param name="migrationBuilder">
        /// The migration builder.
        /// </param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Palindrome");
        }
    }
}
