using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DummyMSRestApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lineDatas_TypeFields_fieldsid",
                table: "lineDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_timeDatas_TimeFields_fieldsid",
                table: "timeDatas");

            migrationBuilder.DropTable(
                name: "TimeFields");

            migrationBuilder.DropTable(
                name: "TypeFields");

            migrationBuilder.DropIndex(
                name: "IX_timeDatas_fieldsid",
                table: "timeDatas");

            migrationBuilder.DropIndex(
                name: "IX_lineDatas_fieldsid",
                table: "lineDatas");

            migrationBuilder.DropColumn(
                name: "fieldsid",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "fieldsid",
                table: "lineDatas");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "fields_ESS",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_EntryStart",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_EntryStop",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_EntryType",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_id",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "lineDatas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "fields_PreferedOreder",
                table: "lineDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_SAPCode",
                table: "lineDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_Title",
                table: "lineDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fields_id",
                table: "lineDatas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id", "displayName", "email" },
                values: new object[] { "1", "Dummy1", "dummy@bosch.com" });

            migrationBuilder.InsertData(
                table: "lineDatas",
                columns: new[] { "id", "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime", "webUrl", "fields_PreferedOreder", "fields_SAPCode", "fields_Title", "fields_id" },
                values: new object[,]
                {
                    { "1", "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "", "1", "0100", "Dummy1", "1" },
                    { "2", "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "", "2", "0200", "Dummy2", "2" }
                });

            migrationBuilder.InsertData(
                table: "timeDatas",
                columns: new[] { "id", "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime", "webUrl", "fields_ESS", "fields_EntryStart", "fields_EntryStop", "fields_EntryType", "fields_id" },
                values: new object[,]
                {
                    { "1", "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "", "false", "2024. 01. 12. 10:04:48", "2024. 01. 12. 15:04:48", "Dummy1", "1" },
                    { "2", "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "", "false", "2024. 01. 12. 9:04:48", "2024. 01. 12. 10:04:48", "Dummy1", "2" },
                    { "3", "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "", "false", "2024. 01. 12. 7:04:48", "2024. 01. 12. 9:04:48", "Dummy2", "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "lineDatas",
                keyColumn: "id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "lineDatas",
                keyColumn: "id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "3");

            migrationBuilder.DropColumn(
                name: "fields_ESS",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "fields_EntryStart",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "fields_EntryStop",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "fields_EntryType",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "fields_id",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "fields_PreferedOreder",
                table: "lineDatas");

            migrationBuilder.DropColumn(
                name: "fields_SAPCode",
                table: "lineDatas");

            migrationBuilder.DropColumn(
                name: "fields_Title",
                table: "lineDatas");

            migrationBuilder.DropColumn(
                name: "fields_id",
                table: "lineDatas");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "timeDatas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "fieldsid",
                table: "timeDatas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "lineDatas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "fieldsid",
                table: "lineDatas",
                type: "nvarchar(450)",
                nullable: true);

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
                    PreferedOreder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SAPCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeFields", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_timeDatas_fieldsid",
                table: "timeDatas",
                column: "fieldsid");

            migrationBuilder.CreateIndex(
                name: "IX_lineDatas_fieldsid",
                table: "lineDatas",
                column: "fieldsid");

            migrationBuilder.AddForeignKey(
                name: "FK_lineDatas_TypeFields_fieldsid",
                table: "lineDatas",
                column: "fieldsid",
                principalTable: "TypeFields",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_timeDatas_TimeFields_fieldsid",
                table: "timeDatas",
                column: "fieldsid",
                principalTable: "TimeFields",
                principalColumn: "id");
        }
    }
}
