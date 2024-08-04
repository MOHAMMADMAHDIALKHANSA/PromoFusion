using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "1" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "10" },
                    { "7fa4d532-e8fd-4785-9bc1-953754c75268", "11" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "2" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "3" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "4" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "5" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "6" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "7" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "8" },
                    { "05b620cf-3017-4b90-b256-80ab0be74c1a", "9" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9fd8ab-abaa-481b-a0f3-c759b004d7c1", "AQAAAAIAAYagAAAAEFZYlOAtsHfRhje1hhy5Dn1KnfA0/rlR/dLIasWSleTdKKB02OxntVk+2ruQGtqYOA==", "f2e56b76-f223-47ba-9427-11d772f76f64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c0244fe-e08e-4c36-8548-a00e3153c597", "AQAAAAIAAYagAAAAEN107cpVL6QQo8IOez896p2n0ks/2Mk8CwElwyMTFh+DaLOrwUO/Jjwxch6jbPNprA==", "91b34f9a-027a-4f91-b4ea-a8177f078fb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b7add51-e069-4c2d-89dd-be938eed8a30", "AQAAAAIAAYagAAAAEP0+aXEwDyPCC6Z/0p2hFh4HHjJBc4bWSI/SdRr1M5mXOnfaVY+f0mL1OAGeNHOviA==", "19dc543e-914c-4d62-a8eb-be827c8d8ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a69bd6-cec9-450c-9e1a-e50fb30e1e20", "AQAAAAIAAYagAAAAEBxwFUins030ymFP9DG+i7xWQD+K7axcxg1gdUytoz0Juf+AmKmQN0T4o3XdSRIsRw==", "9a78c86e-8766-49cd-981b-7dfb57eb5423" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0d682a1-e68e-487d-bc18-1ac855547746", "AQAAAAIAAYagAAAAEJ+PbdCCL3AGzZwSygkMsMHAQu9ytwSqtmyzz/EmvZuSd5lvE9umxG7KG1VInETzvw==", "f8c60369-876b-41c5-8375-a3dc9bccdb22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9047deef-af6b-4a35-811e-71034ab161ab", "AQAAAAIAAYagAAAAEPBZWZl6XBWOGNd2WwEb6TudXe1MQDhKCdL6/vEJdXAO0drJN0t3iakX6HEMYcDNwA==", "61c3cfad-7378-4509-a3f7-70e41d86768e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8058118-7015-48c6-af16-991fe86fc00a", "AQAAAAIAAYagAAAAEMK5GKaNuA0gN6bOnsXZGk9ufXmk1wpHLzyfb/aMS4ju/bp+BDl0S5cLAt9K6esY4w==", "bbc8f6eb-8e8f-40a9-837a-f16691e08b01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84a14e9f-c045-4663-b90b-eab0565e2d26", "AQAAAAIAAYagAAAAEOrhatYa58T3DwLrVOOWE7FXp8t5QUmhTteQuOr/SKohtKiFWjshcbQX0qJuydnbOw==", "131cb346-2df6-4916-884a-1a0102cd91bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17724f8-65df-47fc-9a41-b3187c3c35f7", "AQAAAAIAAYagAAAAEOuhDylMqQDAlOBpHHomhLCmgUzL2i8qJfYVhtVb98mH2qseenWQpEqmAaWCTumh2Q==", "ffe0abd4-3d6d-4730-ac00-2a77cc5d5bc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2158cbee-cab2-4910-b687-908987144add", "AQAAAAIAAYagAAAAEHZAtDMnHL5JahxOnc0oNGLSLXQ0wjpbt0KbBjBYCgXAeVFf+xm8X4vp3rsDaYZXzQ==", "af4a2464-a0f4-4adb-9e21-02b7b67e7f24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7274efcf-174f-4b38-b763-f8bf1460aaea", "AQAAAAIAAYagAAAAEFOeNUvivciwTseJyX6fZfwlr7J+2eBuDzpMQp5DSAHJd+o8auAvVdrGqY82giv2rQ==", "dc3be8cd-5785-4653-8115-7bf294110e19" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6734));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7fa4d532-e8fd-4785-9bc1-953754c75268", "11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65d6c2dd-d38a-49a7-bd71-b0d4a8de1aa5", "AQAAAAIAAYagAAAAEIfIQtf+YMEL20j14PmwK/hyIbWTozT6I5uzapIpRtGMrQ319wumoRQ04vCPMT5Tgw==", "0a939e45-67ea-49bc-bca1-b83388321788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d56dc05-18c2-4fe7-8d56-b9206af57453", "AQAAAAIAAYagAAAAEBxfQLhMq4O46ujtW0OtmpB8DZxbPCv2Vml0Y/Gdzd03nWuhhV2pkzrpspkTd8pgpw==", "5327db33-f374-4c9d-afe8-879c98cbbb7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05670685-1c30-4c50-b0e7-b4eaeb7cf357", "AQAAAAIAAYagAAAAEPqef3hFC34sENGS2BoO00rph1QuJ/km3JX0LVVD/C1PikxpnFYZ69lfqH+FC9OM1A==", "ebde7be0-9d9e-4e78-8381-7db389674ccb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c24dd52-63e8-4861-b08a-47305a49d5fd", "AQAAAAIAAYagAAAAEHABv4phwCjJYxWOJqAMDtcY68JD1/9dRIL2QF7+QA9rWzWLCqzxwsvVQXXTWFBpBg==", "73cbf248-fde8-4303-888e-e34fff67810f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36844f7a-33f4-47c3-be07-441287056938", "AQAAAAIAAYagAAAAEO41rSJUrxU7Wzjjl2NuU7bBe3vFrIZ7JHuZSYRZ6w71e6pXcHo9ZbQ7psPH2dVNxg==", "120a88d6-976c-4741-8ba4-fadd46c148d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52fd8b5e-1c80-4fd6-b28f-565e5c413d76", "AQAAAAIAAYagAAAAEPEQ0J7zFZ8iJO1LL29vELbmqEyO4xH6zvzweNLgYBW/pt7WqToru6rwE8eBJOq1wQ==", "4ccae42e-2519-41ee-a4f0-9390ab29c19b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06aa4666-15ef-451a-8ff5-1f974ad52523", "AQAAAAIAAYagAAAAEFiTLk8QzEjhFAZbeRcWFp+DCu6gZwe4y6qCCv/s3INPz5zHVGRjRrrctAVIVu1NnQ==", "61c125ef-6664-4e31-adff-bab3cb081772" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b5a2469-47c5-470a-b132-a4a5800a99db", "AQAAAAIAAYagAAAAEG6LMiFt+ZtYR3uEJRBME7AfiMKV5uEPs5V8Arcoh0pRWiO6cb6JeRyCWYLEyA4kdQ==", "f54398c6-9800-4f41-9591-0873f214009b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1f04674-935c-46a2-9c84-f79ffe516dd2", "AQAAAAIAAYagAAAAEG3/Q/s+bUXLfL7qYuZLhVhkzXLSWyiQTnbJLuw0TPxrwxu9Sy6b4K4UzaP81z2L2g==", "33ed3dba-a198-4596-b9b7-699455085633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98feed64-3e4a-4d91-8eed-b2389f52f6fe", "AQAAAAIAAYagAAAAEDaAJF+ntdSFcSwyKn49XN7Yjnzv2/WXtnFMVKYQR+vDpsI94UAGfxmz9Vz+8fv5lg==", "b1d29f7f-dbbb-408e-8d36-82305d7c84f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "076bdc09-9cb2-454f-9851-39996c05c62e", "AQAAAAIAAYagAAAAEBSHoOZ2sB0479m0FRGYIjFGZIhcuPXfPAUOb7CqjuKk7eW4ieXxQiIm0PhCvdysMQ==", "3bcdaa1c-eb5b-44dc-b990-db9fbe59de28" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 40, 26, 461, DateTimeKind.Local).AddTicks(3706));
        }
    }
}
