using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class k : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f79b42f-2f93-402e-b8e4-8729d730a22b", "AQAAAAIAAYagAAAAEHKLQh/wccOkFKsCjC7tZV1H4cMlo8YzxofPTvbov0XrPece+6n7CF0CFIxuz2As3Q==", "f85bfa1e-632c-4bd1-8970-5426559830c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f1e3e09-e6cb-4ec0-ab9a-8e26c3781c25", "AQAAAAIAAYagAAAAEBkOlCoZanAzW32xFNWByWyCkiB/RYGaZp8Js6LgPmwwFJEqAKlsjVcz3P5X1m4HUQ==", "05780a71-4202-4cd3-aec0-57dea2bf713e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43c2b687-2bfb-47c8-adad-b02e94c3a496", "AQAAAAIAAYagAAAAEExKYsKrjWhOqqVjN6hUwy9QmXLRMN2dg12QqZ3qJmMYkgfG2vvX3KYnmyXbS4GjEQ==", "d8ec050e-a8a1-4c5f-9a32-933f26d554c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e6d3528-4b1f-4072-aa7a-6fc6c698c657", "AQAAAAIAAYagAAAAEM99W2aTfrLOdQpih3t20Rz7XFMVkDjU4GXNL61Tvsjupx81qZsp0bIyxHBEGgeUew==", "38d36df8-7c9a-4597-9a5c-c3d73dcda899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07ff359c-ecbd-400f-8579-f4dc3dc59826", "AQAAAAIAAYagAAAAECsgQd+sxNzVqxwl0BM31eRXKcVOzGFuv+ilRpZ9RhaU31HIcqh8XcrY5gWrr/TIUw==", "2954ca4f-ac70-445f-b0f5-1984ee86c633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2630bfb3-10cb-41c7-a814-7e4d9eee35f3", "AQAAAAIAAYagAAAAEC44ZpUZhkdug5hzCdP6iq9G84g616Meu5EdasKAronJJZvn0Ad4tcTPTxeoPAMLFg==", "e35ba586-7d78-403e-9900-1a75e1b0abee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34eaf4ff-5614-473b-a157-3355dd810815", "AQAAAAIAAYagAAAAEC2Kc6W3vHWVRbSo/uDaTJ5nk0EcgLwi47aZ1JNpG643MALQLXEV/43m9fJSjSOhRQ==", "6e52e90b-207b-4cf4-a194-c7686545e04a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aaa16a5-a6db-4092-b79d-fc4c76f0fa0d", "AQAAAAIAAYagAAAAEPwH+dYf8x/AWjVj2MQtdnoCO3Qta2dDu3ba3XmMoJnHcOpAJnEr/1JOqREj+OzV7A==", "b71285be-72e0-4bcd-b731-12b0adafb431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4983d7a-9832-4c16-a930-973d91ed444e", "AQAAAAIAAYagAAAAEDVL20kRqT0M4nFxsBPMjEYLkHDBywr8mYkTSU+gIqQ01/5wh75aCXZmz7ji4iOHTw==", "c668f1df-e8e0-42cf-b441-04160219b1f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0da1d0d9-b061-461c-973f-dc890eeb7f37", "AQAAAAIAAYagAAAAELOPpCCaPzbudZzKTKhXvrISnk7w47lKaO2mAWRU+ajBdMoV+hKkOHxiQiJBq3NNFQ==", "3e2c594d-09d5-4673-b0ec-010f6ef23fa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "447310e1-78ee-40b3-a245-6e74fedfefd0", "AQAAAAIAAYagAAAAEGPUiGsFM3k0H+lLFjOmzYS22h0HrvsdjvNyvpBiZ7oOpjhrBJbw82dwcqasrBOFoA==", "17910c46-6b00-4f63-8026-6b681f9902c7" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 23, 15, 0, 206, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MarketingAgencyId",
                table: "Payments",
                column: "MarketingAgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Customers_CustomerId",
                table: "Payments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_MarketingAgency_MarketingAgencyId",
                table: "Payments",
                column: "MarketingAgencyId",
                principalTable: "MarketingAgency",
                principalColumn: "MarketingAgencyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Customers_CustomerId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_MarketingAgency_MarketingAgencyId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_MarketingAgencyId",
                table: "Payments");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3df430bf-ef21-444e-83b1-d1027c7063d7", "AQAAAAIAAYagAAAAEDIKFyl1OYxbWM2Y7itX2fBzSjeg/iqSmJbRiTn9b8KHwzlw4EAuETHvj/LCtdK4sA==", "a6832137-7405-4b3b-aa7d-10e6e551bc9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76563c49-1502-4de1-9fef-ee95df6842da", "AQAAAAIAAYagAAAAELtR40G8TmPjBdXtz2/rDmJrOoyr+z9ZPiY8zwCdUOx/jgEUbUNtWRfbwU72oTLJ8g==", "dc7720ce-bce2-4466-9190-c7db65f6b2f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eea2b0e4-ed29-43cf-954a-4600931b8572", "AQAAAAIAAYagAAAAEBkZaPC581kSY6PWCMtBdFeTopOBP7zxf/tp2mrJKeSwbcD8Shyjc1Ix8dBER+tKFQ==", "b0fd5842-e434-4ed0-bfec-39ac0760b8e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b36d7cf-1a82-4464-9892-dd10634f3636", "AQAAAAIAAYagAAAAENXH2M0f0IsGOHrUFOGa00N57axc3smql34qKlQDKRvqxJvCwAEiS2CG6Nm052/T1g==", "efcbf931-d3a7-483e-8ac7-67b1c92babb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49d8369-986d-4e75-9331-67f1e800e409", "AQAAAAIAAYagAAAAECxKQcoXIDrDlrzLbdvIIL9lBzIdWqFGMSmd7Hw9fpvQkc2yPW2ArvLduNvwkjnnow==", "430e967a-7f77-4e95-bf51-67157d9742d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fd0e731-1b15-4e2e-bbeb-2725aa122df4", "AQAAAAIAAYagAAAAECd3kJYYjtMs4zAwR42D6xEJw615BXrMVF9lZjDHUcLLUxO7iEoKKeaa46dzuxjG0w==", "a9897915-06eb-4bc8-b653-0acdbc866a69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e0d9827-fadf-4e68-bb3e-eb1afbbbd31e", "AQAAAAIAAYagAAAAEKPy1pwRZcCgkKqJ8KgRPh8qVrXr5QVkSFqQVhY7ylnKW8T+RbGrgfFeGkzLhh198g==", "56c5ae74-f419-447c-aa60-fd6f9360fec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5ce7d94-3048-43ee-aac1-a7186226d444", "AQAAAAIAAYagAAAAEEGF1km7tKLuBIYxeYUvtEg16bwh1IdxlXMiqWaOCHJPe6gPjGPayZc7gaUGu4wAaw==", "7eb4cbc4-5c45-4de8-b444-a27bec5d30f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "134b6c76-3cb6-4276-913c-1c8228ef281b", "AQAAAAIAAYagAAAAECBsziizJ1toBKmVM17FlsAfw7Yts7Z2xVZQuxJaAM/+SbKjmhD0iMXaEcYcrVMgGQ==", "0a2e8583-399e-400c-b4d8-6a01a788f750" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad749ec3-25d5-4ef2-b4d9-bcbfc2020b0c", "AQAAAAIAAYagAAAAEMaW27iyLJxbpg1u9QeLjbMCrqpOE8JDNTqK/dBJMxQ7rQNkod0ESDh9QJZjI5+/UA==", "11e27c01-d850-4a14-8103-e2d11f028568" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f0c3bdf-56bb-45e8-8cc7-13f9140907c2", "AQAAAAIAAYagAAAAEOQXEH8DRvKcEkeL6as9YxGhZtXgd8W6QcWFneccT6fZ02IZZNGUi47Y1U8M0vxPGQ==", "8706072e-aa3e-4a48-8821-e9caa2c69dbc" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 22, 15, 8, 505, DateTimeKind.Local).AddTicks(2487));
        }
    }
}
