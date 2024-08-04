using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "AdministratorId",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ae5ceb6-1dfc-4048-b552-2abc6b847df2", "AQAAAAIAAYagAAAAEMogZRHppJWqnBFoGmroD1g2AA+AAIGgMCP2zln1p1pPXW4AX/F5wC/LWU54gbISVA==", "56bd1b3d-18ef-4e63-a77d-119be38c4ad2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d6c41cf-a930-4f2e-80dc-aa2af5d55fc9", "AQAAAAIAAYagAAAAED36nhUlF/U9U4bfYoNExAj6c3KmNWdDdQD4rFQrZHMCA6VPr6a6Iigmr3yLMxaUMQ==", "6f055448-4460-4134-b68d-20d86c527830" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "601de459-e556-4d2e-b69e-5dc9edceb42d", "AQAAAAIAAYagAAAAEByOxebMU8EkT8MzwW6vrNxvA9KRbDNi27JHMOQO1eTKP6OQTN0bjQuN/0L2RwDDhw==", "a02a2ab5-3c6b-427a-bc70-c558fdc25162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14ff652e-c3cf-4c19-b86a-a04ef8c8db4a", "AQAAAAIAAYagAAAAEKkgSOqwmDRIaOHvp1pC2QERdqA1plOBpmkLSbHpmXevXnfVEqDvesFkDx3dkrn/lg==", "8d608158-dbee-4b66-a222-57aef826b0de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8068932d-ead9-4b0d-acee-7ef3a39fa51e", "AQAAAAIAAYagAAAAEFKA0xWlSst52e0P/4qjL3mAXq98cu5cnq4PcrXY4GCUugOevK89EG47FhQ2AcANrA==", "cf16ee49-71b4-4814-9bdb-db0fd69d84c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "964e7001-132e-426e-8d57-5c43c3a6ee4e", "AQAAAAIAAYagAAAAEGy+zxzb2V2HwCkmEW2pld5TVpQivYWBZSrynbxaOIW6zxA8OEJtvhw7wz9veT9AyA==", "af992da9-c477-4c4b-bd89-b074335b76d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4ac5d2f-ad4e-4b15-86f8-178bf9db7d10", "AQAAAAIAAYagAAAAEJyfWc6uNh08SFxAc/8t0Evbo09QJx6nEysG12Cu/MRErHqJ4ewNeMAroOIisjE5xQ==", "ff0d4d09-b707-4e8a-942d-862ea24a8275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43f4eb10-3b91-4e9e-b4fa-1b4eb4e227e6", "AQAAAAIAAYagAAAAEMp0T2/4Jl9S27GtRdn9RV39k4Dr/kk0NnsyhtFVpN+0n3KknzTEP/r5LMG0xsmF1g==", "69b30007-b0a6-4321-8b94-b1e31afca009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "996ff2ce-f41a-43dc-8726-129bc4c3a428", "AQAAAAIAAYagAAAAEB6eTMseWecvQfBm2ouSal2hfzgT9QsSmaBV5e/eyzc+PM3prfG9pHrf6u5Wyul+1A==", "ff820f63-ee1d-4d7e-b752-305cfe28d1a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad142fb0-6f8d-4e7e-b798-2c4f95c4a664", "AQAAAAIAAYagAAAAEPscrjBC/PPnrrj0JBMXskh9o0mCyvx9eVRqsc2xYNFeyYW+S8QnyLP6s4l9Y5Ychw==", "d4febbca-8769-4318-9d3d-e6292121bc60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "912614b2-f631-49bb-b7b5-2a8e9ea5c5f5", "AQAAAAIAAYagAAAAEBD2A1zawjX3lD5XZFSeh0VU3HpKMJkXPrB307KgawyH+e5mCtflyJTZxwp5RztMjw==", "955cc3ff-6766-43ba-920a-900c3910a16d" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 40, 49, 915, DateTimeKind.Local).AddTicks(7653));
        }
    }
}
