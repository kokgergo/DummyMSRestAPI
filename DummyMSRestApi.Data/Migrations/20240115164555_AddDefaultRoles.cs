using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DummyMSRestApi.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b3186e3d-0403-48fb-9ea8-282e3d9a55ba", "f20a045f-97d7-463f-aa7d-02c596f91b8f", "User", "USER" },
                    { "d8f12d99-bfbe-479a-b7ab-7e51771eff6f", "4eff0152-cae9-4960-bf6c-390a606654b5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "2024. 01. 15. 17:45:55", "2024. 01. 15. 17:45:55", "2024. 01. 15. 12:45:55", "2024. 01. 15. 17:45:55" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "2024. 01. 15. 17:45:55", "2024. 01. 15. 17:45:55", "2024. 01. 15. 11:45:55", "2024. 01. 15. 12:45:55" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "3",
                columns: new[] { "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "2024. 01. 15. 17:45:55", "2024. 01. 15. 17:45:55", "2024. 01. 15. 9:45:55", "2024. 01. 15. 11:45:55" });

            migrationBuilder.UpdateData(
                table: "typeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "2024. 01. 15. 17:45:55", "2024. 01. 15. 17:45:55" });

            migrationBuilder.UpdateData(
                table: "typeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "2024. 01. 15. 17:45:55", "2024. 01. 15. 17:45:55" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3186e3d-0403-48fb-9ea8-282e3d9a55ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8f12d99-bfbe-479a-b7ab-7e51771eff6f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "displayName" },
                values: new object[] { "1", 0, "100db7ec-73de-4763-84fd-61f54dbaea1a", "dummy@bosch.com", false, false, null, null, null, null, null, false, "0817f1f0-3c6a-48a9-b60e-bee75b9036f6", false, null, "Dummy1" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "2024. 01. 15. 17:19:32", "2024. 01. 15. 17:19:32", "2024. 01. 15. 12:19:32", "2024. 01. 15. 17:19:32" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "2024. 01. 15. 17:19:32", "2024. 01. 15. 17:19:32", "2024. 01. 15. 11:19:32", "2024. 01. 15. 12:19:32" });

            migrationBuilder.UpdateData(
                table: "timeDatas",
                keyColumn: "id",
                keyValue: "3",
                columns: new[] { "createdDateTime", "lastModifiedDateTime", "fields_EntryStart", "fields_EntryStop" },
                values: new object[] { "2024. 01. 15. 17:19:32", "2024. 01. 15. 17:19:32", "2024. 01. 15. 9:19:32", "2024. 01. 15. 11:19:32" });

            migrationBuilder.UpdateData(
                table: "typeDatas",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "2024. 01. 15. 17:19:32", "2024. 01. 15. 17:19:32" });

            migrationBuilder.UpdateData(
                table: "typeDatas",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "createdDateTime", "lastModifiedDateTime" },
                values: new object[] { "2024. 01. 15. 17:19:32", "2024. 01. 15. 17:19:32" });
        }
    }
}
