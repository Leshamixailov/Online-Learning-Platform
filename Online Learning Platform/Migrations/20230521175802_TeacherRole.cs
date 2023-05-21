using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Learning_Platform.Migrations
{
    public partial class TeacherRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "ConcurrencyStamp",
                value: "a0e13e4a-b78d-4435-884e-c2d5c0ebfdb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75b8eec6-a17f-4baa-9966-3a1d98bb8e83", "Teacher", "TEACHER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "373581e5-83bc-415d-9386-8c67b437ec52", "AQAAAAEAACcQAAAAEIW7+/OCIoi14Tttk65S9tkPKF+Xl15394vRAE83FRIw5SJ6dhEN9p2ydFLAX1sYzg==", "5700f740-672f-4d14-a365-408b7be77511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54dbef4e-3a34-4b6e-9400-29e70adea086", "AQAAAAEAACcQAAAAED6LvB/aiArCoGSYGAyifbnZGo13cDlSdS/8z/O+hDELEIvKMzQRhnJpOOjanROo7A==", "cdd204f6-c35d-4269-8971-ef9c6cb55fbd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2979c442-d6c5-4329-9275-4be70fbb907c", "Manager", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01968059-b5de-4e22-a3fa-23fd501b097c", "AQAAAAEAACcQAAAAEA5br8Kgq/Gm1rPA8lKayQ1DuTBC74ZFAgZzlvzyNSJhM0a6VXgeBVtmTYQr2CAeOA==", "8ba15fc3-8b27-4f01-af48-5abf24957b21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9fd1988-583f-4775-819e-e47e6dceb833", "AQAAAAEAACcQAAAAEAuD1hDBnED9ARPccrP3MtmxlrSj7RNC9fFnN8f2mqEDpFwVMta6Hz6OgVaf+U4FxQ==", "e486dbfa-34b7-45a5-8cd0-26a73daed96e" });
        }
    }
}
