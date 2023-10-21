using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Products.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    AccountId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LargeDescription_TextualMarkup = table.Column<int>(type: "int", nullable: false),
                    LargeDescription_Value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => new { x.AccountId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "DynamicFieldVo",
                columns: table => new
                {
                    ProductAccountId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicFieldVo", x => new { x.ProductAccountId, x.ProductId, x.Id });
                    table.ForeignKey(
                        name: "FK_DynamicFieldVo_Products_ProductAccountId_ProductId",
                        columns: x => new { x.ProductAccountId, x.ProductId },
                        principalTable: "Products",
                        principalColumns: new[] { "AccountId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Multimedia",
                columns: table => new
                {
                    MultimediaId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedia", x => new { x.AccountId, x.Id, x.MultimediaId });
                    table.ForeignKey(
                        name: "FK_Multimedia_Products_AccountId_Id",
                        columns: x => new { x.AccountId, x.Id },
                        principalTable: "Products",
                        principalColumns: new[] { "AccountId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynamicFieldVo");

            migrationBuilder.DropTable(
                name: "Multimedia");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
