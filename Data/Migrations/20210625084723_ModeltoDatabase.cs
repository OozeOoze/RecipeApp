using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeApp.Data.Migrations
{
    public partial class ModeltoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ing001 = table.Column<bool>(type: "bit", nullable: false),
                    Ing002 = table.Column<bool>(type: "bit", nullable: false),
                    Ing003 = table.Column<bool>(type: "bit", nullable: false),
                    Ing004 = table.Column<bool>(type: "bit", nullable: false),
                    Ing005 = table.Column<bool>(type: "bit", nullable: false),
                    Ing006 = table.Column<bool>(type: "bit", nullable: false),
                    Ing007 = table.Column<bool>(type: "bit", nullable: false),
                    Ing008 = table.Column<bool>(type: "bit", nullable: false),
                    Ing009 = table.Column<bool>(type: "bit", nullable: false),
                    Ing010 = table.Column<bool>(type: "bit", nullable: false),
                    Ing011 = table.Column<bool>(type: "bit", nullable: false),
                    Ing012 = table.Column<bool>(type: "bit", nullable: false),
                    Ing013 = table.Column<bool>(type: "bit", nullable: false),
                    Ing014 = table.Column<bool>(type: "bit", nullable: false),
                    Ing015 = table.Column<bool>(type: "bit", nullable: false),
                    Ing016 = table.Column<bool>(type: "bit", nullable: false),
                    Ing017 = table.Column<bool>(type: "bit", nullable: false),
                    Ing018 = table.Column<bool>(type: "bit", nullable: false),
                    Ing019 = table.Column<bool>(type: "bit", nullable: false),
                    Ing020 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
