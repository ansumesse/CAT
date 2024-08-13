using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tasks.Part_1.Migrations
{
    /// <inheritdoc />
    public partial class ModifyPKNamecourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Course",
                type: "VARCHAR(50)",
                maxLength: 100,
                nullable: false,
                comment: "this a new comment",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AddPrimaryKey(
                name: "CourID",
                table: "Course",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "CourID",
                table: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Course",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 100,
                oldComment: "this a new comment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");
        }
    }
}
