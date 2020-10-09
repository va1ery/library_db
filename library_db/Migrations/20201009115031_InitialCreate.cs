using Microsoft.EntityFrameworkCore.Migrations;

namespace library_db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Gen_ID = table.Column<int>(type: "INT", nullable: false),
                    Gen_Name = table.Column<int>(type: "INT", nullable: false),
                    Gen_Description = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Gen_ID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Pos_ID = table.Column<int>(type: "INT", nullable: false),
                    Pos_Name = table.Column<int>(type: "INT", nullable: false),
                    Pos_Salary = table.Column<int>(type: "INT", nullable: false),
                    Pos_Duties = table.Column<int>(type: "INT", nullable: false),
                    Pos_Requirements = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Pos_ID);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Pub_ID = table.Column<int>(type: "INT", nullable: false),
                    Pub_Name = table.Column<int>(type: "INT", nullable: false),
                    Pub_City = table.Column<int>(type: "INT", nullable: false),
                    Pub_Address = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Pub_ID);
                });

            migrationBuilder.CreateTable(
                name: "Reader",
                columns: table => new
                {
                    Rd_ID = table.Column<int>(type: "INT", nullable: false),
                    Rd_Full_Name = table.Column<int>(type: "INT", nullable: false),
                    Rd_BD_Date = table.Column<int>(type: "INT", nullable: false),
                    Rd_Sex = table.Column<int>(type: "INT", nullable: false),
                    Rd_Address = table.Column<int>(type: "INT", nullable: false),
                    Rd_Phone_Number = table.Column<int>(type: "INT", nullable: false),
                    Rd_Passport_Data = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reader", x => x.Rd_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Emp_ID = table.Column<int>(type: "INT", nullable: false),
                    Emp_Full_Name = table.Column<int>(type: "INT", nullable: false),
                    Emp_Age = table.Column<int>(type: "INT", nullable: false),
                    Emp_Sex = table.Column<int>(type: "INT", nullable: false),
                    Emp_Address = table.Column<int>(type: "INT", nullable: false),
                    Emp_Phone_Number = table.Column<int>(type: "INT", nullable: false),
                    Emp_Passport_Data = table.Column<int>(type: "INT", nullable: false),
                    Pos_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Emp_ID);
                    table.ForeignKey(
                        name: "FK_Employee_Position_Pos_ID",
                        column: x => x.Pos_ID,
                        principalTable: "Position",
                        principalColumn: "Pos_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Bk_ID = table.Column<int>(type: "INT", nullable: false),
                    Bk_Name = table.Column<int>(type: "INT", nullable: false),
                    Bk_Author = table.Column<int>(type: "INT", nullable: false),
                    Bk_Realise_Date = table.Column<int>(type: "INT", nullable: false),
                    Pub_ID = table.Column<int>(type: "INT", nullable: false),
                    Gen_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Bk_ID);
                    table.ForeignKey(
                        name: "FK_Book_Genre_Gen_ID",
                        column: x => x.Gen_ID,
                        principalTable: "Genre",
                        principalColumn: "Gen_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_Pub_ID",
                        column: x => x.Pub_ID,
                        principalTable: "Publisher",
                        principalColumn: "Pub_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Returned_Books",
                columns: table => new
                {
                    Rb_Return_Date = table.Column<int>(type: "INT", nullable: false),
                    Rb_GiveOut_Date = table.Column<int>(type: "INT", nullable: false),
                    Rb_Return_Flag = table.Column<int>(type: "INT", nullable: false),
                    Emp_ID = table.Column<int>(type: "INT", nullable: false),
                    Rd_ID = table.Column<int>(type: "INT", nullable: false),
                    Bk_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Returned_Books_Book_Bk_ID",
                        column: x => x.Bk_ID,
                        principalTable: "Book",
                        principalColumn: "Bk_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returned_Books_Employee_Emp_ID",
                        column: x => x.Emp_ID,
                        principalTable: "Employee",
                        principalColumn: "Emp_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returned_Books_Reader_Rd_ID",
                        column: x => x.Rd_ID,
                        principalTable: "Reader",
                        principalColumn: "Rd_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Gen_ID",
                table: "Book",
                column: "Gen_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Pub_ID",
                table: "Book",
                column: "Pub_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Pos_ID",
                table: "Employee",
                column: "Pos_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Returned_Books_Bk_ID",
                table: "Returned_Books",
                column: "Bk_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Returned_Books_Emp_ID",
                table: "Returned_Books",
                column: "Emp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Returned_Books_Rd_ID",
                table: "Returned_Books",
                column: "Rd_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Returned_Books");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Reader");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
