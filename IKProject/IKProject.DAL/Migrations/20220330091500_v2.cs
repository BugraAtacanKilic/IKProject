using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IKProject.DAL.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 776, DateTimeKind.Local).AddTicks(9246), new DateTime(2022, 3, 30, 12, 14, 58, 778, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(7962), new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(8835), new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(8846), new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "RolTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 3, 30, 12, 14, 58, 781, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "RolTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "RolTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(716), new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(1506), true, new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7495), true, new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7513), true, new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7521), true, new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7530), true, new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7539), new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7547), new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7555), new DateTime(2022, 3, 30, 12, 14, 58, 782, DateTimeKind.Local).AddTicks(7556) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 421, DateTimeKind.Local).AddTicks(390), new DateTime(2022, 3, 30, 11, 52, 19, 423, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(2438), new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4338), new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "RolTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "RolTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8639), new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "RolTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8671), new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 429, DateTimeKind.Local).AddTicks(599), false, new DateTime(2022, 3, 30, 11, 52, 19, 429, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7241), false, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7292), false, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7303), false, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7312), false, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7322), new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7331), new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7342) });
        }
    }
}
