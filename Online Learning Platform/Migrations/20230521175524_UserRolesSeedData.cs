using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class UserRolesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "4114237e-bb12-4075-9855-1fd909984c15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "2979c442-d6c5-4329-9275-4be70fbb907c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01968059-b5de-4e22-a3fa-23fd501b097c", "AQAAAAEAACcQAAAAEA5br8Kgq/Gm1rPA8lKayQ1DuTBC74ZFAgZzlvzyNSJhM0a6VXgeBVtmTYQr2CAeOA==", "8ba15fc3-8b27-4f01-af48-5abf24957b21" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NickName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Year" },
                values: new object[] { "06674cf0–5812–4cfe - afbf - 59f706d72cf6", 0, "b9fd1988-583f-4775-819e-e47e6dceb833", "Teacher", false, true, null, "Teacher", "TEACHER", "TEACHER", "AQAAAAEAACcQAAAAEAuD1hDBnED9ARPccrP3MtmxlrSj7RNC9fFnN8f2mqEDpFwVMta6Hz6OgVaf+U4FxQ==", null, false, "e486dbfa-34b7-45a5-8cd0-26a73daed96e", false, "Teacher", 1010 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "06674cf0–5812–4cfe - afbf - 59f706d72cf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "06674cf0–5812–4cfe - afbf - 59f706d72cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "e60bf21a-a59f-4b62-8d1f-974db67646f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "9d8795a7-be11-4513-9c07-47f757560e29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0f10dd-eab5-4dfd-94c9-3d10843a01c2", "AQAAAAEAACcQAAAAEFntkxXT6KFUOTfj211/9qSUMdn906WCA4bLuUbTL5ajAu/5c6kdq9oZCpEldZOuQg==", "e0437faa-feb8-4ae8-867d-eab428cc2ae6" });
        }
    }
}
