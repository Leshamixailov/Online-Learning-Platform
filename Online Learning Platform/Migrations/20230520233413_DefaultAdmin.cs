using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class DefaultAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NickName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Year" },
                values: new object[] { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, "cc201bf3-fb37-436e-9ccc-c593588b5a5d", "Admin", false, true, null, "Admin", "ADMIN", "ADMIN", "AQAAAAEAACcQAAAAEDbIa2hX5rTzVEX5p0s8TwWhgxXN94BPJHAmdSkXznSkrByNGrZqO8zBnVRD7N9eoQ==", null, false, "c9db057d-e8a1-4e56-a9f2-2010128e6485", false, "Admin", 1010 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6");
        }
    }
}
