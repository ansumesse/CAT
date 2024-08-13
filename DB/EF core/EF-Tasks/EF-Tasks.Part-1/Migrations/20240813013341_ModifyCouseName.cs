using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tasks.Part_1.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCouseName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Course",
                newName: "CName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CName",
                table: "Course",
                newName: "CourseName");
        }
    }
}
