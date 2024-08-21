using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig_StudentEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDate", "EnrollmentDate", "FirstName", "ImgUrl", "LastName", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehmet", "/images/studentImages/e1.png", "Ekinci", false },
                    { 2, new DateTime(2001, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", "/images/studentImages/e2.png", "Yılmaz", false },
                    { 3, new DateTime(2002, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmet", "/images/studentImages/e3.png", "Çelik", false },
                    { 4, new DateTime(2003, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehmet", "/images/studentImages/e4.png", "Demir", false },
                    { 5, new DateTime(2002, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zeynep", "/images/studentImages/k1.png", "Kara", false },
                    { 6, new DateTime(2001, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elif", "/images/studentImages/k2.png", "Yurt", false },
                    { 7, new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fatma", "/images/studentImages/k3.png", "Öztürk", false },
                    { 8, new DateTime(2002, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emine", "/images/studentImages/k4.png", "Aydın", false },
                    { 9, new DateTime(2001, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayşe", "/images/studentImages/k5.png", "Güneş", false },
                    { 10, new DateTime(2002, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burak", "/images/studentImages/e5.png", "Koç", false },
                    { 11, new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emre", "/images/studentImages/e6.png", "Arslan", false },
                    { 12, new DateTime(2002, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oğuz", "/images/studentImages/e7.png", "Turan", false },
                    { 13, new DateTime(2001, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cem", "/images/studentImages/e8.png", "Sönmez", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
