using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "AdministratorId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "AdministratorId", "Email", "FirstName", "ImgUrl", "LastName", "Role", "UserId" },
                values: new object[] { 1, "mhmd@gmail.com", "MohammadMahdi", "https://example.com/image.jpg", "ALkhansa", "Administrator", "11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddaed7b9-6c25-4759-9c55-f604eb0197ba", "AQAAAAIAAYagAAAAEBqjB6bM/TVkMTVSKJT6nW6TIbskb+vZoNnSNdFh70cCJln24Vfch19kQyyXjYbjaw==", "ec83f622-5c24-4ad7-bb30-e526e07454a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a441634d-ac2a-4ff3-a4de-300acf8e5eb1", "AQAAAAIAAYagAAAAEJSOCZnsdrcxodFtUwFyarO6PQkSxx8aIemMAVC8l8xUHrbtu7gaRus2inbwR+/jxQ==", "0e9eb75a-bffd-459f-9a04-7736d76753cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cde92f3e-46a1-4ec4-a8bb-adca69c99c7f", "AQAAAAIAAYagAAAAEJEsm2lBCKlVOvsPuj72rqj4e0E1sHJKdV0XR2dVKh9RswG5ZmQ3ljdi1H8tHCl5og==", "f777132c-f342-4b54-94f2-95524aa925ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ea9491-d8dc-482c-99ca-9aa86ea3efa2", "AQAAAAIAAYagAAAAEFUcnz7Fx6zK81pCkwuB0hXldvwZZcv80SwS2zk32A8K3dTosBSPm/kqWskAsX9f4w==", "911387ec-7743-4970-ad41-1fcd3721d27d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71214d37-3635-40a5-a493-fe032b72ae1c", "AQAAAAIAAYagAAAAEHn0rqBUVr8fR4f5rH47Nn7qJt5AMDuiOSs54EmJfblhbNb8gDsDkGo7ZB5UZSpUmA==", "f7571744-5c92-4071-bb68-ffbfda553bcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a9d9824-47c5-40a7-91ba-547da86a0823", "AQAAAAIAAYagAAAAEDMPNzO2uRbR403LPs0XAzhboTIh4WIvaiQu/V2mIFpgmvd/qtgd6d3YtUm7yZFuTg==", "df393b1b-c8d8-4d79-880b-e2a6e9cce4db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a33d351f-a918-427c-b935-60541bf8d92f", "AQAAAAIAAYagAAAAEBX+1TA85WxLzSXTpPuFV1bTe6fCFPZUsIJV5u1Pnh+udSSe4tDM9A4RNIEDkApDLg==", "a6dcf6f3-edd9-4f15-898d-aefd396a06df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f10bcddb-92e2-43d3-98e7-25e9a03644bf", "AQAAAAIAAYagAAAAEO72n6+5Av7O8jcOk2ACK1Yfwy+xJvqcDVX69PMeaxsNq1gsETs2CSZMtkEVFy3vnw==", "cb263ab5-c3de-46a8-9af9-dfddd74bf7c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cdf10ac-9347-4fb8-9552-d7a048c124a3", "AQAAAAIAAYagAAAAEDLi6fT/3+UqvzG46VYkTKCFoaFbLQGNZZhIktuEW5gPBpfI0g7DdD3Iuy354zL9gA==", "5c0b17e7-f84a-41ba-b844-e3c448f07c1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bc2fc9e-a340-4465-878a-e763349ad6eb", "AQAAAAIAAYagAAAAEEqL1SFDjdhd/HeNiclHKAGaiYHb6hDbQAxknQivFG/Xw3T3x+X/OUwPKwhMqz67Vg==", "5c704ed1-9aa0-4e73-9874-218921d38000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cff271c-34f9-45c1-8285-672b381d5b06", "AQAAAAIAAYagAAAAEGZa96Z1TuXCzifcJ9r9wg41BIxLfRVNyLZSO4WwowctOrA+ZKB89769oRz6YrEgGA==", "dd44a6f7-4683-492c-b1af-06f8c2592bf7" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 48, 3, 431, DateTimeKind.Local).AddTicks(5745));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "AdministratorId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "AdministratorId", "Email", "FirstName", "ImgUrl", "LastName", "Role", "UserId" },
                values: new object[] { -1, "mhmd@gmail.com", "MohammadMahdi", "https://example.com/image.jpg", "ALkhansa", "Administrator", "11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b29d243-e0af-4ad0-a016-25279c903acf", "AQAAAAIAAYagAAAAEKjfZ2DyJdhiMru2LjEH41MBS5yIA+2DI3dJtmojfwCyxufukLdq+rai0rC0yYZeFQ==", "8f5369e4-24f4-459d-9466-b7d02d0e75b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4981361a-8335-40fb-8b18-4a086d417e62", "AQAAAAIAAYagAAAAELgOGIcidFE5z8nvI1QK3mnQ3YwXwJvoZOzxykVW4winLhnEBHzbUe5iLxZjE5yIJw==", "531b3ed2-e7c6-4ac8-8487-6602382de2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e6e2e66-4964-4681-81b7-e726eb19f0bc", "AQAAAAIAAYagAAAAEJg1yspIhb+V5XAG6doClKJi2Uf3olyd9bYi7g81GtnKkGJCqO2VUztPOYjRrvznyA==", "39669fce-fcd3-4151-ae8e-62905f89e11e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89e7a5e3-5c75-4c4c-a8df-95184da70cb9", "AQAAAAIAAYagAAAAEEdYnOfl6vpkUkEXKI+4b2o/UWw+Dv+QE7QnbXFn3rd7xOk5Qb7EcI8QA1fuCAe8nA==", "d07d09d6-94fc-47c7-b566-df98a7001eaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9aaa302-278c-4b44-8cce-5f4bc6e4d64d", "AQAAAAIAAYagAAAAEJr2Wi+yrcaj4nUks+CXW9hg6ggozESamA1llYu1XmyaEBUjZFLRrUgVeJ5RQ881gQ==", "eae64e8c-2032-463c-988e-a8abe1e4c136" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c52b4c6f-b67c-4412-986a-1205639d2354", "AQAAAAIAAYagAAAAEFS8X1UUNRYAsCZXQauWJVnCP+e5vWoPJ8nNADs+weB0z8y0v7JXzUdT0Ze1n3xmWQ==", "055c2349-8222-47b0-8314-ccddde2b5b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d8fe402-4214-416d-b160-e66f6fe4fc8b", "AQAAAAIAAYagAAAAEEuMZ5HO777M9Ys+FoCGBESik6M98e5SaunyOpzCICoEByzWSKvvompspDloffxE7g==", "bfe185f1-2d74-4c9f-b518-8888903344ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "208283e2-ec19-44ab-b8af-5914b522b9ce", "AQAAAAIAAYagAAAAEGZaHgKKFH+VajbfP7Eci9ubLpfzqKCZsQCo8xmafcUBLc+sg11UnrcacKny36bMDA==", "bc2523a3-3544-4ece-a68b-9b7ee1b3aa40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9752d295-29ce-45dd-b038-917711fc9e5f", "AQAAAAIAAYagAAAAEGCXMeWAPnKdyhXwiA6KxAnsaQGsS5RlLlu2NGaarYFxgRxss5OvMu+fLcjdjw7FrA==", "9ff5462a-04cb-491e-91a3-75ec29c1a9c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6edbe9d3-19a1-4f7f-bc21-744afc636c0f", "AQAAAAIAAYagAAAAEFizr2KH+XJLdO+aY1ibRJSlVBpprnbh/k/qCPR5yG/wEn2htXU3yRqiCCNJ5TMHyw==", "7f6ba3ca-a423-49f3-a5bc-967a262db1aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45736aba-4360-4d37-a2e2-43de8378648a", "AQAAAAIAAYagAAAAEBHskQMhDhSmgeR2JToOsE6MCpVUHZjist70/XxooauW3SpkjcjD+e9fo4f23RO9vQ==", "49169827-47b7-4bb2-a069-ba09c2c0844c" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 45, 52, 810, DateTimeKind.Local).AddTicks(2872));
        }
    }
}
