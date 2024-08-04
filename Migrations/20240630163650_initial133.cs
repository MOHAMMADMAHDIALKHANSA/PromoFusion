using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial133 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserId",
                table: "Customers");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "MarketingAgency",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "MarketingAgency",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
                values: new object[] { "0fd2e993-ab22-4dfc-8253-c669fd6743eb", "AQAAAAIAAYagAAAAELFwtQjqWLJLBzaa4bGnw5iVsup8hqvumjySws1WRLsHOb5nEwfj2XZ/IwbEW11xOw==", "357b45b4-d186-4307-995d-5001050338b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c466274d-6ca9-4bfc-ba08-4e581069fec3", "AQAAAAIAAYagAAAAECvp4WRZueiNJSh0IbIstbT7VnsonEcA1XU5r4BHt2MjZuFm3o2o151iTg+kUo6lkA==", "7bc796fd-fb1c-4332-863f-ec80ad83146e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f2587a-82ac-4073-b998-2dbad2285fd0", "AQAAAAIAAYagAAAAEDYM8XAAhIXaHlt1TWHABZM001WwifGJjAS2/l1f005WZTrIkJPZD/XukRNbsd1zow==", "d3f94a58-325a-4962-819d-6c74d33cba75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e43f778c-06c1-401b-b039-64de6ab12a2a", "AQAAAAIAAYagAAAAEGSSoPBVyRZCc/uuqU6WxsV0x9b4yTHYUuVV6rPhwydc9ENYATFkyFOy5DV6MoR2QA==", "82bd0c42-24fd-4c27-a1f8-85a913e1f9ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf9bee98-1e18-45a7-ab9f-9125324c6ea9", "AQAAAAIAAYagAAAAEHbw77n08To8ho6ZIQJ7SW2rVspeucBLGzfj/e0NHaIeyTNfk7jQQqAnDkm8Z+YZFQ==", "a168e42c-54a9-43dc-92fc-03374774675c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caa4e794-47e3-4060-8ed9-9e6d453e2018", "AQAAAAIAAYagAAAAELWi5Cmkozvq86j+RkuDd8Oh4Lq1+Yx+LJkxFQUDFYGbu5tdgJMH+UNP/CWI/w6WVQ==", "3ec8c3b6-e5c8-4b25-baa4-a7fdd35ef052" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ed0c1b4-02b7-4a86-aae0-d7278b3c9f97", "AQAAAAIAAYagAAAAEIq9obEJ7i+p4SxOpVbKG5+DEqMk8wJ9+kaXSByunOBkmFIhosrrtHQwKka7QFtpjg==", "08378baa-0b06-45eb-b13e-16d5ea0e3798" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d47cc94-e0ff-4a5e-a270-ef0664a5f3bb", "AQAAAAIAAYagAAAAEOBGjrjkawzB+05n/MmxoOD797n5IIR/zDGF1EDXd61/TNa8i5TnPwb+VeHIKzQw1A==", "60460ada-eb8d-4f58-bacd-a25e904a7e06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "350a5f9c-4907-4074-9448-6ba8fb92cf8c", "AQAAAAIAAYagAAAAEGzqZNfl4HAGZAsLSmVtLVPXv369AA1bdzCsH9w7ZEQdVGgl2EvKMncDAYjmez67CA==", "318fc430-390b-44a5-95f4-63b0e4b28787" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfbdfcff-c08d-4517-953c-08bb52c74131", "AQAAAAIAAYagAAAAEAc4YtkZjm6hLM8axsygEHZBz+Cvh1DsCe2KrsylbdrinoRP+nKbGnBGVtU56xEUhg==", "c089d8f0-8b05-424d-8cb7-e0bdca4613cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc291ddc-97fe-429a-a8ae-f212d239d72e", "AQAAAAIAAYagAAAAEDiPvIYtVryZGbkW6y4K2UVfCdY+JeC5k2dPmIhCom+rLJMl+grmuv2snTAkNRfkKw==", "f4f8d91d-13f4-491c-a64b-1c989a1087bd" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 16, 9, 32, 832, DateTimeKind.Local).AddTicks(7027));

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
    }
}
