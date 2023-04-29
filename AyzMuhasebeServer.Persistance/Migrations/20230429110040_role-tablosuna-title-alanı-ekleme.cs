using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AyzMuhasebeServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class roletablosunatitlealanıekleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Roles");
        }
    }
}
