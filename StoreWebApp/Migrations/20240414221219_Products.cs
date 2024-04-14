using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AgeGroupName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    SocialSharingEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsReturnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsExchangeable = table.Column<bool>(type: "INTEGER", nullable: false),
                    PickupEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsTryAndBuyEnabled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColourName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenderName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SeasonName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StyleOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StyleName = table.Column<string>(type: "TEXT", nullable: false),
                    StyleValue = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StyleOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsageName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    ProductDisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    CatalogAddDate = table.Column<int>(type: "INTEGER", nullable: false),
                    BrandId = table.Column<int>(type: "INTEGER", nullable: false),
                    AgeGroupId = table.Column<int>(type: "INTEGER", nullable: true),
                    GenderId = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseColourId = table.Column<int>(type: "INTEGER", nullable: true),
                    Colour1Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Colour2Id = table.Column<int>(type: "INTEGER", nullable: true),
                    SeasonId = table.Column<int>(type: "INTEGER", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    UsageId = table.Column<int>(type: "INTEGER", nullable: true),
                    MasterCategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    SubCategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    ArticleTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AgeGroups_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "AgeGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_ArticleTypeId",
                        column: x => x.ArticleTypeId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Categories_MasterCategoryId",
                        column: x => x.MasterCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Categories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Colours_BaseColourId",
                        column: x => x.BaseColourId,
                        principalTable: "Colours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Colours_Colour1Id",
                        column: x => x.Colour1Id,
                        principalTable: "Colours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Colours_Colour2Id",
                        column: x => x.Colour2Id,
                        principalTable: "Colours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Usages_UsageId",
                        column: x => x.UsageId,
                        principalTable: "Usages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductToStyleOptionJunctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    StyleOptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductToStyleOptionJunctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductToStyleOptionJunctions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductToStyleOptionJunctions_StyleOptions_StyleOptionId",
                        column: x => x.StyleOptionId,
                        principalTable: "StyleOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[] { -1, "test@example.com", "password" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AgeGroupId",
                table: "Products",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ArticleTypeId",
                table: "Products",
                column: "ArticleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BaseColourId",
                table: "Products",
                column: "BaseColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Colour1Id",
                table: "Products",
                column: "Colour1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Colour2Id",
                table: "Products",
                column: "Colour2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenderId",
                table: "Products",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MasterCategoryId",
                table: "Products",
                column: "MasterCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SeasonId",
                table: "Products",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UsageId",
                table: "Products",
                column: "UsageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductToStyleOptionJunctions_ProductId",
                table: "ProductToStyleOptionJunctions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductToStyleOptionJunctions_StyleOptionId",
                table: "ProductToStyleOptionJunctions",
                column: "StyleOptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "ProductToStyleOptionJunctions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StyleOptions");

            migrationBuilder.DropTable(
                name: "AgeGroups");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Usages");
        }
    }
}
