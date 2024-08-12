using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Tasks.Part_1.Migrations
{
    /// <inheritdoc />
    /// 
    //- Create a custom migration to add or modify database schema elements. Apply the custom migration to update the database schema
    public partial class MyOwnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO EMPLOYEES VALUES('ALI')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM EMPLOYEES WHERE NAME = 'ALI'");
        }
    }
}
