using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IKProject.DAL.Migrations
{
    public partial class IKProjeDBV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MailTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ActiveUsersLimit = table.Column<short>(type: "smallint", nullable: false),
                    ActiveUsersNo = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RolTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TC = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhotoUrlPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendEmailTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailActiveUser = table.Column<bool>(type: "bit", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    RolTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Companys_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_RolTypes_RolTypeID",
                        column: x => x.RolTypeID,
                        principalTable: "RolTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "ID", "ActiveUsersLimit", "ActiveUsersNo", "Adress", "CreatedDate", "Description", "IsActive", "LogoPath", "MailTag", "ModifiedDate", "Name", "Phone" },
                values: new object[] { 1, (short)5, (short)5, "Reşitpaşa Mah. Katar Cad. Teknokent ARI 3 No: 4 B3 Sarıyer / İstanbul.", new DateTime(2022, 3, 30, 11, 52, 19, 421, DateTimeKind.Local).AddTicks(390), "Bilgeadam bir teknoloji şirketidir.", true, "~\\assets\\img\\Companys\\1.png", "@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 423, DateTimeKind.Local).AddTicks(4151), "Bilgeadam Teknoloji", " 08502016000" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreatedDate", "IsActive", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(2438), true, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(2472), "İnsan Kaynakları" },
                    { 2, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4313), true, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4327), "Yazılım" },
                    { 3, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4338), true, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(4342), "Pazarlama" }
                });

            migrationBuilder.InsertData(
                table: "RolTypes",
                columns: new[] { "ID", "CreatedDate", "IsActive", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(6382), true, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(6400), "Admin" },
                    { 2, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8639), true, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8656), "Şirket Yöneticisi" },
                    { 3, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8671), true, new DateTime(2022, 3, 30, 11, 52, 19, 428, DateTimeKind.Local).AddTicks(8676), "Çalışan" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adress", "BirthDate", "CompanyID", "CreatedDate", "DepartmentID", "EmailActiveUser", "EndDate", "IsActive", "Mail", "ModifiedDate", "Name", "Password", "PhoneNumber", "PhotoUrlPath", "RolTypeID", "SendEmailTime", "StartDate", "Surname", "TC", "Title" },
                values: new object[,]
                {
                    { 2, "Üsküdar/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7241), 1, true, null, false, "gamzealtinelli@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7267), "Gamze", "Abc123.", "05456332568", "~\\assets\\img\\Users\\2.jpg", 2, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Altınelli", "45687895321", "Senior Yazılım Uzmanı" },
                    { 1, "Kağıthane/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 429, DateTimeKind.Local).AddTicks(599), 2, true, null, false, "hasanserhatbayar@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 429, DateTimeKind.Local).AddTicks(614), "Hasan Serhat", "Abc123.", "05554443696", "~\\assets\\img\\Users\\1.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Bayar", "46195695988", "Junior Yazılım Uzmanı" },
                    { 3, "Beşiktaş/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7292), 2, true, null, false, "tanerguler@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7294), "Taner", "Abc123.", "05442365898", "~\\assets\\img\\Users\\3.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Güler", "45698756235", "Junior Yazılım Uzmanı" },
                    { 4, "Kartal/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7303), 2, true, null, false, "murathantandogan@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7305), "Murathan", "Abc123.", "05325659632", "~\\assets\\img\\Users\\4.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Tandoğan", "35698756985", "Junior" },
                    { 5, "Sarıyer/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7312), 3, true, null, false, "yunussukrugulten@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7314), "Yunus Şükrü", "Abc123.", "05412327852", "~\\assets\\img\\Users\\5.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Gülten", "12365896321", "Pazarlama Uzmanı" },
                    { 6, "Çengelköy/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7322), 3, true, null, false, "ahmetmuhsinoglu@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7323), "Ahmet", "Abc123.", "05345883211", "~\\assets\\img\\Users\\6.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Muhsinoğlu", "754232659852", "Pazarlama Uzman Yardımcısı" },
                    { 7, "Kadıköy/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7331), 2, true, null, false, "serdaratay@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7333), "Serdar", "Abc123.", "05123336598", "~\\assets\\img\\Users\\7.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Atay", "25369856325", "Junior" },
                    { 8, "Çekmeköy/İstanbul", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7341), 2, true, null, false, "kaanlokum@bilgeadam.com", new DateTime(2022, 3, 30, 11, 52, 19, 430, DateTimeKind.Local).AddTicks(7342), "Kaan", "Abc123.", "05235556321", "~\\assets\\img\\Users\\8.jpg", 3, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "Lokum", "45698965321", "Junior" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companys_MailTag",
                table: "Companys",
                column: "MailTag",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyID",
                table: "Users",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentID",
                table: "Users",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mail",
                table: "Users",
                column: "Mail",
                unique: true,
                filter: "[Mail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolTypeID",
                table: "Users",
                column: "RolTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TC",
                table: "Users",
                column: "TC",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "RolTypes");
        }
    }
}
