using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tasks.Part_1.Migrations
{
    /// <inheritdoc />
    public partial class AddComputedNameId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameId",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[NAME] + ', ' + [ID]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameId",
                table: "Instructors");
        }
    }
}
