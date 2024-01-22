using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DummyMSRestApi.Migrations
{
    /// <inheritdoc />
    public partial class FixBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lineDatas_UserType_createdByid",
                table: "lineDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_timeDatas_UserType_createdByid",
                table: "timeDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lineDatas",
                table: "lineDatas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "timeDatas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "lineDatas");

            migrationBuilder.RenameTable(
                name: "lineDatas",
                newName: "typeDatas");

            migrationBuilder.RenameIndex(
                name: "IX_lineDatas_createdByid",
                table: "typeDatas",
                newName: "IX_typeDatas_createdByid");

            migrationBuilder.AlterColumn<string>(
                name: "createdByid",
                table: "timeDatas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdByid",
                table: "typeDatas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_typeDatas",
                table: "typeDatas",
                column: "id");

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "createdByid", "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "1", "2024. 01. 15. 16:50:19", "2024. 01. 15. 16:50:19", "2024. 01. 15. 11:50:19", "2024. 01. 15. 16:50:19" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "createdByid", "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "1", "2024. 01. 15. 16:50:19", "2024. 01. 15. 16:50:19", "2024. 01. 15. 10:50:19", "2024. 01. 15. 11:50:19" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "3",
                columns: new[] { "createdByid", "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "1", "2024. 01. 15. 16:50:19", "2024. 01. 15. 16:50:19", "2024. 01. 15. 8:50:19", "2024. 01. 15. 10:50:19" });

            migrationBuilder.UpdateData(
                table: "typeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "createdByid", "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "1", "2024. 01. 15. 16:50:19", "2024. 01. 15. 16:50:19" });

            migrationBuilder.UpdateData(
                table: "typeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "createdByid", "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "1", "2024. 01. 15. 16:50:19", "2024. 01. 15. 16:50:19" });

            migrationBuilder.AddForeignKey(
                name: "FK_timeDatas_UserType_createdByid",
                table: "timeDatas",
                column: "createdByid",
                principalTable: "UserType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_typeDatas_UserType_createdByid",
                table: "typeDatas",
                column: "createdByid",
                principalTable: "UserType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_timeDatas_UserType_createdByid",
                table: "timeDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_typeDatas_UserType_createdByid",
                table: "typeDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_typeDatas",
                table: "typeDatas");

            migrationBuilder.RenameTable(
                name: "typeDatas",
                newName: "lineDatas");

            migrationBuilder.RenameIndex(
                name: "IX_typeDatas_createdByid",
                table: "lineDatas",
                newName: "IX_lineDatas_createdByid");

            migrationBuilder.AlterColumn<string>(
                name: "createdByid",
                table: "timeDatas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "timeDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "createdByid",
                table: "lineDatas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "lineDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lineDatas",
                table: "lineDatas",
                column: "id");

            migrationBuilder.UpdateData(
                table: "lineDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48" });

            migrationBuilder.UpdateData(
                table: "lineDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "2024. 01. 12. 10:04:48", "2024. 01. 12. 15:04:48" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "2024. 01. 12. 9:04:48", "2024. 01. 12. 10:04:48" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "3",
                columns: new[] { "UserId", "createdByid", "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "1", null, "2024. 01. 12. 15:04:48", "2024. 01. 12. 15:04:48", "2024. 01. 12. 7:04:48", "2024. 01. 12. 9:04:48" });

            migrationBuilder.AddForeignKey(
                name: "FK_lineDatas_UserType_createdByid",
                table: "lineDatas",
                column: "createdByid",
                principalTable: "UserType",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_timeDatas_UserType_createdByid",
                table: "timeDatas",
                column: "createdByid",
                principalTable: "UserType",
                principalColumn: "id");
        }
    }
}
