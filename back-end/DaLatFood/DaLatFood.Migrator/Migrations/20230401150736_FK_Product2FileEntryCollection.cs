using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaLatFood.Migrator.Migrations
{
    /// <inheritdoc />
    public partial class FK_Product2FileEntryCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FileEntryCollectionId",
                schema: "ProductSchema",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_FileEntryCollectionId",
                schema: "ProductSchema",
                table: "Product",
                column: "FileEntryCollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_FileEntryCollection_FileEntryCollectionId",
                schema: "ProductSchema",
                table: "Product",
                column: "FileEntryCollectionId",
                principalSchema: "FileSchema",
                principalTable: "FileEntryCollection",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_FileEntryCollection_FileEntryCollectionId",
                schema: "ProductSchema",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_FileEntryCollectionId",
                schema: "ProductSchema",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "FileEntryCollectionId",
                schema: "ProductSchema",
                table: "Product");
        }
    }
}
