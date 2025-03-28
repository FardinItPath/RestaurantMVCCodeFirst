using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantMVCCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedForeginkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Users_CreatedBy",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_CreatedBy",
                table: "Menu");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Menu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDT",
                table: "Menu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_UserId",
                table: "Menu",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Users_UserId",
                table: "Menu",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Users_UserId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_UserId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UpdatedDT",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Menu");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CreatedBy",
                table: "Menu",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Users_CreatedBy",
                table: "Menu",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
