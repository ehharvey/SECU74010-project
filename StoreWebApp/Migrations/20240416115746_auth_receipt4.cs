using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class auth_receipt4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Purchases",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Purchases");
        }
    }
}
