using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class CategoryCPU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameCPU",
                table: "Categoreis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "a822d720-2c20-4382-a316-3512f3846d64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "e90dd0c4-a4be-49a3-b2ff-d787aef40500");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c284b82-d0d7-4f79-a61c-2e015c6c0254", "AQAAAAEAACcQAAAAEBlmr38xANM11aOlWA7BtD9w8rMevy3NRofdGDsBH80KDXz5rzpg7k/Vm2se37pnbw==", "bcccc1b1-b47e-4cc3-a788-0ab2de303ecb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34604626-9f55-406f-86de-a4f68781a066", "AQAAAAEAACcQAAAAEE5CAfq539XYOJlWN3XXxlkgB69n7Fj8IV8GcnTdYBq/ZUGBaan/vL3x0uE7FfgvTw==", "3d79d6c6-27f8-40fb-80e2-634ee90fd23a" });

            migrationBuilder.UpdateData(
                table: "Categoreis",
                keyColumn: "Id",
                keyValue: 1,
                column: "NameCPU",
                value: "Kategoriya_1");

            migrationBuilder.UpdateData(
                table: "Categoreis",
                keyColumn: "Id",
                keyValue: 2,
                column: "NameCPU",
                value: "Kategoriya_2");

            migrationBuilder.UpdateData(
                table: "Categoreis",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameCPU",
                value: "Kategoriya_3");

            migrationBuilder.UpdateData(
                table: "Categoreis",
                keyColumn: "Id",
                keyValue: 4,
                column: "NameCPU",
                value: "Kategoriya_4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameCPU",
                table: "Categoreis");

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
    }
}
