using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Govinet_Front_End_Connection_Checker.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chekers",
                columns: table => new
                {
                    prop1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    prop2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prop3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prop4 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chekers", x => x.prop1);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chekers");
        }
    }
}
