using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Data.Migrations
{
    public partial class SubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategoreis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoreis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoreis_Categoreis_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categoreis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SubCategoreis",
                columns: new[] { "Id", "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Податегория 1" },
                    { 2, 2, "Податегория 2" },
                    { 3, 3, "Податегория 3" },
                    { 4, 4, "Податегория 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoreis_CategoryID",
                table: "SubCategoreis",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategoreis");
        }
    }
}
