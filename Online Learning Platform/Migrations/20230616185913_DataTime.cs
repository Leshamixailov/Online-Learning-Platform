using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class DataTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "e6f96582-bf60-4849-8359-fd4117f8a37b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "301c262a-8509-4186-a93c-e2af85dd7031");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93967a52-687b-40af-bf86-4d958fdf68d0", "AQAAAAEAACcQAAAAEOmYvH/dKI81WZRstUjc5B4P73O/mz9TtNdlnr85XA9Lz7rqo4XPU7rmqsXeQQS26A==", "b8e2c30f-0a7a-4707-af48-d9cf36cc2e18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ec2cc63-78f9-4cb3-b632-1c0d0c5da52a", "AQAAAAEAACcQAAAAEIbIwjmD/KuzvbCiR/Re5AF50pBfXALoh+HrWHknMJcVLoA4/b2RRUXdbFhlO86N8Q==", "cd8cce5b-39db-4b0d-a8f9-9e20f0711212" });
        }
    }
}
