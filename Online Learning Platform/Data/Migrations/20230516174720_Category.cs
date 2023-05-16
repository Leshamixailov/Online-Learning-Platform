using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Data.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoreis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoreis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoreis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoreis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoreis_Categoreis_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categoreis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoreis",
                columns: new[] { "Id", "Action", "Controller", "Name", "Route" },
                values: new object[,]
                {
                    { 1, "", "", "Категория 1", "" },
                    { 2, "", "", "Категория 2", "" },
                    { 3, "", "", "Категория 3", "" },
                    { 4, "", "", "Категория 4", "" }
                });

            migrationBuilder.InsertData(
                table: "SubCategoreis",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Подкатегория 1" },
                    { 2, 2, "Подкатегория 2" },
                    { 3, 3, "Подкатегория 3" },
                    { 4, 4, "Подкатегория 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoreis_CategoryId",
                table: "SubCategoreis",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategoreis");

            migrationBuilder.DropTable(
                name: "Categoreis");
        }
    }
}
