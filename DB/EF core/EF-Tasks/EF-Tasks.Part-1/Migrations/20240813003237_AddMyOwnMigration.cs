using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tasks.Part_1.Migrations
{
    /// <inheritdoc />
    /// 
    //- Create a custom migration to add or modify database schema elements. Apply the custom migration to update the database schema.
    public partial class AddMyOwnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO INSTRUCTORS VALUES ('ALI')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM INSTRUCTOR WHERE NAME = 'ALI'");
        }
    }
}
