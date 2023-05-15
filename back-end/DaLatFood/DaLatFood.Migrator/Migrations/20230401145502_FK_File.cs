using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaLatFood.Migrator.Migrations
{
    /// <inheritdoc />
    public partial class FK_File : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FileEntryCollectionId",
                schema: "FileSchema",
                table: "FileEntry",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileEntry_FileEntryCollectionId",
                schema: "FileSchema",
                table: "FileEntry",
                column: "FileEntryCollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileEntry_FileEntryCollection_FileEntryCollectionId",
                schema: "FileSchema",
                table: "FileEntry",
                column: "FileEntryCollectionId",
                principalSchema: "FileSchema",
                principalTable: "FileEntryCollection",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileEntry_FileEntryCollection_FileEntryCollectionId",
                schema: "FileSchema",
                table: "FileEntry");

            migrationBuilder.DropIndex(
                name: "IX_FileEntry_FileEntryCollectionId",
                schema: "FileSchema",
                table: "FileEntry");

            migrationBuilder.DropColumn(
                name: "FileEntryCollectionId",
                schema: "FileSchema",
                table: "FileEntry");
        }
    }
}
