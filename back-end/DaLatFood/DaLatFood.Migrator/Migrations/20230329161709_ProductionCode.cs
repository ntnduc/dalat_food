using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaLatFood.Migrator.Migrations
{
    /// <inheritdoc />
    public partial class ProductionCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                schema: "ProductSchema",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                schema: "ProductSchema",
                table: "Product");
        }
    }
}
