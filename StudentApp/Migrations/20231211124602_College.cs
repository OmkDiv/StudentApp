using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentApp.Migrations
{
    /// <inheritdoc />
    public partial class College : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "College",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "College",
                table: "Student");
        }
    }
}
