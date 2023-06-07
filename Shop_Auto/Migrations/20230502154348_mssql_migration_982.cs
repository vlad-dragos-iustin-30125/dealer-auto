using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Auto.Migrations
{
    /// <inheritdoc />
    public partial class mssql_migration_982 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Car");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Car",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
