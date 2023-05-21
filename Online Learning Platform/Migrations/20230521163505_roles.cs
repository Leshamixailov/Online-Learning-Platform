using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "e60bf21a-a59f-4b62-8d1f-974db67646f8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "9d8795a7-be11-4513-9c07-47f757560e29", "Manager", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0f10dd-eab5-4dfd-94c9-3d10843a01c2", "AQAAAAEAACcQAAAAEFntkxXT6KFUOTfj211/9qSUMdn906WCA4bLuUbTL5ajAu/5c6kdq9oZCpEldZOuQg==", "e0437faa-feb8-4ae8-867d-eab428cc2ae6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "02174cf0–9412–4cfe - afbf - 59f706d72cf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "02174cf0–9412–4cfe - afbf - 59f706d72cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc201bf3-fb37-436e-9ccc-c593588b5a5d", "AQAAAAEAACcQAAAAEDbIa2hX5rTzVEX5p0s8TwWhgxXN94BPJHAmdSkXznSkrByNGrZqO8zBnVRD7N9eoQ==", "c9db057d-e8a1-4e56-a9f2-2010128e6485" });
        }
    }
}
