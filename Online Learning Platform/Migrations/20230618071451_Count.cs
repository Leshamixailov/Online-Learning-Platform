using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class Count : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Courses",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "38631d5c-e10d-460d-a788-6c492ca8e2ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "34c8abbe-5f03-40e7-8bb6-ed0294f54052");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cc827a6-4f79-4107-ba93-ea1f94b6dd42", "AQAAAAEAACcQAAAAEOGbW+MGANa4p5hGdcPvotgLIU4SmjoAkhVkWy36ciBan9eod2AtFZfwyoQ0+f6byg==", "5bc4607e-c66e-48e7-bf23-670cf5882e6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7504ea33-941f-4423-802e-02eff3963bbf", "AQAAAAEAACcQAAAAEFRq8KTHuKbkYbT6hALx/jb0/VMNzO4h67Idqz+VH76PfQa+N75KOkrz8tUSg/p7cw==", "2aedb4c3-a4e2-4490-af8c-5198a090343c" });
        }
    }
}
