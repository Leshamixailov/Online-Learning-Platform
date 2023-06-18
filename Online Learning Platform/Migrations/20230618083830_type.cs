using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "edaf2a57-4786-48ff-aff4-3cb3c4dcb247");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "5058084a-1c86-4afe-809f-5d8781bd340a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96bed1ee-d58c-478b-8b5a-39d40fe36fbd", "AQAAAAEAACcQAAAAEJW/cyHrkugpIUtIj0tIFRbL/qQTPX+7VtRQ+EyAtWgymZdC5TLN0e3P+kXpoGCpOQ==", "8e3d88a5-8b7d-4ad9-90e2-504c2d752996" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4841ca6-4bbd-4ba0-8991-f9eb9e6a2db4", "AQAAAAEAACcQAAAAEI9Sd9J6yuAsJTY7BqjJ2KbAZkbNo6+S352jYPRwWmVxQ7B5WgPhj7azOt5DlonqDQ==", "63d1ea5a-073e-433e-a970-25140e2faec8" });
        }
    }
}
