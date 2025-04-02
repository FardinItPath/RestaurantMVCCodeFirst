using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantMVCCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Menu");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menu",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menu",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Menu",
                type: "int",
                nullable: true);
        }
    }
}
