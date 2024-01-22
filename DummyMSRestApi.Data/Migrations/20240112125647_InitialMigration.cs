using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DummyMSRestApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeFields",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryStop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFields", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypeFields",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SAPCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferedOreder = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeFields", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    displayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lineDatas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createdDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastModifiedDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    webUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fieldsid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    createdByid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lineDatas", x => x.id);
                    table.ForeignKey(
                        name: "FK_lineDatas_TypeFields_fieldsid",
                        column: x => x.fieldsid,
                        principalTable: "TypeFields",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_lineDatas_UserType_createdByid",
                        column: x => x.createdByid,
                        principalTable: "UserType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "timeDatas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createdDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastModifiedDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    webUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fieldsid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    createdByid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeDatas", x => x.id);
                    table.ForeignKey(
                        name: "FK_timeDatas_TimeFields_fieldsid",
                        column: x => x.fieldsid,
                        principalTable: "TimeFields",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_timeDatas_UserType_createdByid",
                        column: x => x.createdByid,
                        principalTable: "UserType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_lineDatas_createdByid",
                table: "lineDatas",
                column: "createdByid");

            migrationBuilder.CreateIndex(
                name: "IX_lineDatas_fieldsid",
                table: "lineDatas",
                column: "fieldsid");

            migrationBuilder.CreateIndex(
                name: "IX_timeDatas_createdByid",
                table: "timeDatas",
                column: "createdByid");

            migrationBuilder.CreateIndex(
                name: "IX_timeDatas_fieldsid",
                table: "timeDatas",
                column: "fieldsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lineDatas");

            migrationBuilder.DropTable(
                name: "timeDatas");

            migrationBuilder.DropTable(
                name: "TypeFields");

            migrationBuilder.DropTable(
                name: "TimeFields");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
