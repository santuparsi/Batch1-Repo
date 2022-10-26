using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCodeFirst_Demo2.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamSize",
                table: "Project",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamSize",
                table: "Project");
        }
    }
}
