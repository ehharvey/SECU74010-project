using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class auth_receipt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Purchases");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Purchases",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
