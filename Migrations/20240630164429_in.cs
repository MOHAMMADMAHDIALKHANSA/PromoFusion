using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class @in : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_applicationUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_applicationUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43385b83-cee8-410d-9c70-f1889eda9798", "AQAAAAIAAYagAAAAEEOae6ErXzlDG0PuJt9+ok+wd2jyswJa9Eyc6jTxkwGMI94Ot/O1DPTvssf7jgLx/A==", "4c070001-12dc-4729-8d9c-c106a79b51c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7afc3b59-6983-428a-a88e-8fc3e6a8d4be", "AQAAAAIAAYagAAAAELtqSvHzCf8mGxBnvq9AvvTsrvxyeVbFNrv/3xncBwQRX5alWcsWVkfZRCNIFOrQkQ==", "31eaa459-9816-42a1-aec2-84af307f1914" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91e0fd9b-a024-44c8-8834-e3af0229afbb", "AQAAAAIAAYagAAAAEAqOi6M4zFyRU1z//FN5gvxpc8U6SiqiDYyl9fFQEkMAT5BljkBVIzBhSf+PbUwWyw==", "362d47b6-adfd-45e9-b592-221693a52369" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe77bb1-fc3d-4425-ade9-8e6105cc28af", "AQAAAAIAAYagAAAAEB3rx7vrgUV9NDPUyhiHrvOvIFkpbtdFNn5KcNU7kBBN5Xlzc89Ln5XWW7HmbaRchg==", "2dff5d75-c82d-4f55-a57a-8cfb12fdc4c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b810105c-0986-4c19-a12e-0ee21d850ee7", "AQAAAAIAAYagAAAAEOUS+6+j+dS2oihMy6bkGZdimrE6NB93o7O3bpLZxECXCvLemlpES3MJOY8cvPs+iQ==", "985af450-18fe-4e27-8812-00235e252034" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dca03db-6c71-475e-8c53-c0555630bc7b", "AQAAAAIAAYagAAAAEKjk3C7wVLCy7Vf49DzRRrbEYSapl94AnbNgwB+KqjAZHuhf4qCe+eZn3obNjqOtug==", "8e113767-51e0-49a6-8281-4448450bc402" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99458aec-bc76-4a58-90e7-aebaef9ce639", "AQAAAAIAAYagAAAAEMG0lR9xWI663NcPI7yEk7jn/pvnHskGp1X6H2gF9rCObMTUaqAkmVAZ9xkwMZHfSw==", "bce1fa51-8fbc-410c-aa8f-dd155dd1a51a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8fbe3c9-1b53-4958-a52a-b142ece86ed6", "AQAAAAIAAYagAAAAEDFoMf5cGJiz/jvsB+nZMfvJQM32EJNw526njPvCFT99+PnCzG22HATETzLdcEEYTA==", "673450c6-3884-4018-bd42-27462064ccd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d89cbb4-8858-4be1-ac2c-1d520ae4e263", "AQAAAAIAAYagAAAAEFcTO+HG/fM5roPRjhsMepHhaNlfjtKq4sa88sL3O49H4OsQzkiT0cAHNkraZldr+Q==", "26a1f3fd-6950-461a-a07c-9e65ab9c84a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6958a4a4-a733-4a90-83d9-7c7ab0d986d3", "AQAAAAIAAYagAAAAECHbp974kbj3o1PxOizSSfVNnTU9z0EgM+PK1N26CCIQdiQ2oWmjiFu5xSU5XnlUFg==", "2cc21c51-43de-4c65-9466-0b7158855da6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e07f2d1d-ab13-429d-bc22-73476617a5f7", "AQAAAAIAAYagAAAAEIU4wgyK2DmldIuSqnIkLhqoQGZt889ZUmZOu1kZVCSey/hzWNEzvS2Pv5p/ZPWXrw==", "e8be3926-e1a3-4c87-b77e-e7b4b6ea29be" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 44, 28, 817, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "applicationUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da04fa4a-65fd-4ec0-b876-cd50a5f437f4", "AQAAAAIAAYagAAAAEEqs1bukseCu1lV6EKIyg8AIETqR//DsjvG0+sNrIWRvFtWh8hCTgRFlJ5y0NpUt+g==", "3f3a5d5e-0418-4112-8dec-0729665959d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36474c4a-4abd-40d7-a3c7-a60ba85432f8", "AQAAAAIAAYagAAAAEBKl7udQxyhrlIk4o/xFXDZPHC56Gs6EZDOeXHYdGpHMzbXsquVuoexFHgBvX/YOHw==", "8e9eb4c2-235d-4042-a034-9b6fdcda6a93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bc6f082-a3aa-47eb-85d2-fb2e0e3d14c0", "AQAAAAIAAYagAAAAEIv+qE9pWHZBFtiS11UX2mAHW5mDgub0m1lO8atqZAURHmPVQdR450taB0wIcYZ5Xw==", "5d04509e-95ca-4936-84c8-a212749d3dc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44047647-87e5-4499-b488-9d7c8291b2e6", "AQAAAAIAAYagAAAAEAcddQZyVVY2+MPulOkmVXUxEw4aGx/VL9xwDv/+ndVWbQ3+uOnzhqT1leFdmPms3w==", "6b540509-c157-4d5e-97f7-697acd10aedb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d41bd816-2a2b-4f06-bbe0-b027d26bc33c", "AQAAAAIAAYagAAAAEG4XycCQ3XhIg2nMzuUdIpRW2kYAfJAFJu9xgWH5wxDv/CUh+uD10xjcElMQD4dRZg==", "66b70075-098c-4c5a-a7bb-980f39c4802b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d5de5fe-a6dc-4bbe-a26b-b913c239d95c", "AQAAAAIAAYagAAAAEL9QCsfonm1VCW20WUeNCfnlsqiNI2d1S48wRn7TaGxf3B7JY4xaEmXTA3TSw+UfZQ==", "295b7efa-b5a4-4ba6-937c-a8eeb58446e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c9a282-dfec-43d8-9d5d-e92a1b8a96d5", "AQAAAAIAAYagAAAAEMOdcIdOkQfHV+xCfLJWqf/uo/BV0dGwg97VUktHLPTOmBZiz6xMOUEw+Gx2oJZU5g==", "e1915063-d21c-49bc-a193-37887c80c782" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d97ece-ab64-4c49-ab44-9110538b984c", "AQAAAAIAAYagAAAAECbEpSsoztA7C38Yaf+kpEuhyFFKCDioUAPn3WWNMscs0PkDxxofJy18KUhxh3sZSw==", "e7356249-11c2-4b58-a61c-b48a4680e39b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e0a1746-681e-4cb2-8979-8ed9b690f65e", "AQAAAAIAAYagAAAAEMMLNB/GJvQkB0WV5aDvw8XlFu8ND7Gj75YbMgynow0NrSOdMgdeKQTRJFS2cT9QkQ==", "60beb7fd-7e47-4970-b9e2-b2a51f79d96d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "519b6cbd-0bd3-42a3-8880-06508dd64c1c", "AQAAAAIAAYagAAAAEDStl/6zjDyRMiiwzprfoYQ+5anlitTHmFgIJ7OQjVPT/4vnOuETmmrw6qbuhLDpSw==", "51c6dc5d-c583-4234-ad37-8dca95ed6ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d093ebb7-4f48-4c58-b8e7-6f644dfb5a48", "AQAAAAIAAYagAAAAELHtGq0iSqCxtfk57/qq1bk8Y0JB4K2YAkTALywUxsxn7Qaf4YyB55v4Uo+0mzf6uQ==", "b84efb1f-ecf4-4911-920c-6e4b6f6d52b9" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 309, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 309, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 309, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 19, 36, 49, 310, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_applicationUserId",
                table: "Customers",
                column: "applicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_applicationUserId",
                table: "Customers",
                column: "applicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
