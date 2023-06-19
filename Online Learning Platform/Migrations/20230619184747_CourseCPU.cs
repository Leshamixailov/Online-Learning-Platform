using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class CourseCPU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameCPU",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "77e16976-1375-49c6-a682-83bbe30c8c35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "115d737e-0646-4a5d-b86d-67f7fee527c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e314865-598c-4a47-9d89-db3d02f37400", "AQAAAAEAACcQAAAAEEWtRnE+lt2lMSd1r8JZDD3YzHlLOpsfCtEFkhs/4lNx7nkBQEDKKqVO+hXAlMjp8w==", "588edc4e-35de-4873-95a8-7b6a76db90e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1626567a-605e-4e06-825b-a12617a61fd3", "AQAAAAEAACcQAAAAELyQeKq7zjCsPGEO9e05ZU6xatOjf5DK9ZaJB4qWc3AvA91aZMvDpv9EQbgtHNE9Lg==", "c8bc624e-a6dd-4a3f-8688-3059bcb1ea49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameCPU",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "e93b9e4f-29d3-4fb6-ba73-d5348ef6f3dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "978543d5-7780-4333-9659-154612981f82");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3140763-bbfc-4790-824d-6c8e4cf5dca4", "AQAAAAEAACcQAAAAEDej8RVjwv+dnUdRXyfPzZUx/7ZvlFthSYXYK/Sz/9t0t2g0YLSg0HyGoyyLs2h5sw==", "6528a4b7-67ac-4ec8-b01a-9bb24444d391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02af4fb2-f3cf-4e6e-a3ee-15e5744c05ee", "AQAAAAEAACcQAAAAELPNfVF/X73AujOjc+VziaHlKC4uyhsAKRxhk0aEzqtII9nKA5P5nsQTYoi6P8BLQQ==", "74cbdef5-0527-49ad-bb77-a81bc92c4c44" });
        }
    }
}
