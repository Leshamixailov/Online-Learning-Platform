using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class metatags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Preview",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Preview",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "020a958e-091b-4535-989e-326c5dcd5d64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "659e1550-56ea-4842-9dbc-a98068376328");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c5390f-3080-4fc5-bf39-2dab04338d91", "AQAAAAEAACcQAAAAEGRvhF4Fi0j+mUwhsJTLrKEIYQIgAffAPW664mygNEP9194Yv3+h0BxtAHg+gJvWhw==", "a8950767-824a-4fe6-9f28-7ac4bffb9f31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7e8c9d2-9091-4b5f-912d-80eb87f171d1", "AQAAAAEAACcQAAAAEDkQPMlyVZqHIuuF9t1FLhuORqS7F9hasp5tXhgMi0Mv5mjY5PYP4Kgs6avK1GzL9g==", "c97b1807-366f-46a5-85f0-03951fea8c10" });
        }
    }
}
