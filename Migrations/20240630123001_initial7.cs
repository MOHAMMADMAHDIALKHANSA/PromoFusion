using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7fa4d532-e8fd-4785-9bc1-953754c75268", "11" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2ef520f-2099-4dcc-8545-4a68003f3465", "AQAAAAIAAYagAAAAECSnisZkpsUL7nxEN49sGGdw/NJ6lsNWKIy2FgFYBOz9Bx4X2RYSj5SkTMaZw7gYXQ==", "72c59f10-658e-4acf-b827-40a0186b292d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d486f60b-9619-402c-bcb2-c7c33e2b53d3", "AQAAAAIAAYagAAAAEIufnD7OY+RyKNuzf0bRqA2zgiAR1TpfDRK3HP78riSnX+v+rzQiy1jEeIreCd+B+g==", "94e93b03-e062-45f4-b7dc-a730ec95f107" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ce9905-2e1a-4c6c-a952-979d72d41179", "AQAAAAIAAYagAAAAEG38AovziG2E6y4rRDkeN5DS/okXfJOCXR/pOrxQ0LTlxDl1g1nZv7pG/hx8NuzTJA==", "50ae66e7-c3d0-4f0d-a7a8-2c3a663c30e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476f08a3-d3ad-4d3d-802d-e355e2fe0b3b", "AQAAAAIAAYagAAAAEFK1grQDRYr4m7g8/Yx3xU4iTPY/NwsdohOH+r9DdwGPv1YkabEOnzINw1C0B7xE9Q==", "9bd62e1b-e875-48ee-9bca-259d3efab408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3478b75a-8f15-4dfe-8a1b-c6316f57786e", "AQAAAAIAAYagAAAAEBeRazunoBvxlTRGoo7mX6z0/rSz7OxIkGcRGtyaTs6r2nxiA9Rtg88ZieTM5UYTVg==", "33ffd6e4-704a-4794-9809-ae91acd04e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b43a018-31e5-4556-bdc0-e2b63d031a2b", "AQAAAAIAAYagAAAAEOazCem7E4y46piZLok6qOkML4TzBkpWjfVJ1t6lvX8DuzeOg9/o0KJvcsR4NlZgxw==", "36404839-b957-424a-8819-be79f65ea2fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ee336f9-7d50-4391-b607-bf677186b810", "AQAAAAIAAYagAAAAEDRmXaxLt6WUGzvkSz8IAumcR9hI5b1zr3J/yW4cr9//XTACbMWc1zyviqnx1aLlMA==", "b15dd282-1489-4a52-941e-a5fc480076c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c71cd7a-eedc-400b-8809-ed7aab9a3dfc", "AQAAAAIAAYagAAAAEL102DTsq4kAPV+vqXQpxWTtyeCv6xuPNruc9Nwsz9l2sXrHkhP6KPLlZaDcGrTOrQ==", "ff88a259-0cc7-419b-be8d-8040a4560f83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e33cfb-a6ff-4afe-9086-aaabd5c3815f", "AQAAAAIAAYagAAAAEHPahejI08peCuFl9Y0AVNIn4tWlyyYt4Lm7HG3ADKmci/WdMp40Zvsc1XDDQV88GA==", "2e95c257-82b8-49b6-b266-0593cacf73bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3be825c-d11a-4b06-9174-ce4d65c41c98", "AQAAAAIAAYagAAAAEGwguiKt/FiMw2vD6CTM0xXgsigPP/6Hvq/jgwXMtTGnbSKuMTW2Jq14kaaEHYzl+A==", "6ada5f3a-25fb-4517-a787-ea4e6a6fe3b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a739ab4a-3bce-4fcb-8f50-1b061a79b19d", "AQAAAAIAAYagAAAAEOKE8c9rtx9R/1mL/OK2IHlGWAC4EDJ4N3Bhgxue8Q7Sz7kE8+QKTFZruwC9wUhHRA==", "98f76b60-45e1-4e1c-b101-9cb42449baf1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 30, 0, 802, DateTimeKind.Local).AddTicks(8395));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05b620cf-3017-4b90-b256-80ab0be74c1a", "11" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7fa4d532-e8fd-4785-9bc1-953754c75268", "11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d18a6b0d-dc84-4523-b68d-86d4c4f3544f", "AQAAAAIAAYagAAAAEGwCSDTD0aF7CmVL74JAgErVlIXz5VJrOMDXysnv1p/olLU4N+JiS+kPWhJiEx8cuA==", "ef0f10a5-7a99-462f-afee-e2a695fad24f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1671ec-9d28-479e-b839-f485e97a6237", "AQAAAAIAAYagAAAAEMZ1QcB6Y92xLAvJwSEVmWBJ+k692c2RwysiV9YuW2Y7rywEBR+vC0A8OpNyR2XNEg==", "5a0c6e75-3f13-4b91-8e9c-7115370805c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9d8652d-2f67-4dcb-a1f7-01b32584f2ce", "AQAAAAIAAYagAAAAEBO1hgtuj7E+nVDvnsEilDyoaGASCQJUNwlHxNrtkBBneNz6bqHIHlCD7Uyr0yNrDQ==", "b8a6aa7c-5155-4c4c-bde3-180dcc2c9ae8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "639b98d2-40dc-4866-9108-e4298061ced8", "AQAAAAIAAYagAAAAEJ7nbMi1waqq4V51r7GYBimpqZBMR6cNyFyHJkxQgyQG+7fsWB2wPvlfP+qemQxRRQ==", "b5f24bbc-9d8a-49ea-b570-dbead954ca6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c40b35fd-0ce0-41eb-aaef-20ccaa0a1b44", "AQAAAAIAAYagAAAAEBXPgvRkgcT30UwpZAb0OsfZZHlJOtsZpdd7NPBLkhfcyh7lpXNB2bhgMEpokJHYBA==", "fda246f6-5349-4424-974a-48d172196e47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38b9f417-b872-4e9e-a515-e93e25693879", "AQAAAAIAAYagAAAAEBZxp2Wzk0MafpMMwqq2oh7jG/REJNMD6kKK/lQrhk4Sfi+QqWVUwEnknsXn725g/g==", "e5e9f1ad-3369-4458-aaa7-79cfd1e88fa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707b6d0f-9d43-4d81-be5a-654e4e9fd57e", "AQAAAAIAAYagAAAAELCh14TsNuVuVJDt554hK+RtLrKu/aCBLsG/XNnMYomYwJXftIq3Xfrlk9wy7Or+kg==", "81c445cb-194c-412c-b85c-fd17a3799c91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90c02f51-e449-49d6-986b-eb95960470cd", "AQAAAAIAAYagAAAAEAKfewN4kG2xTMbc2TT9vmOmeqUfzVIZY9NSXuprStL4KRLNExIWO5jkXRI5nwIzlg==", "93c1f7d8-aa4f-4a34-895b-0f62375156ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d744093-3efc-47c2-aa03-615a94498e96", "AQAAAAIAAYagAAAAEHHlkKzH5Y4UFUF4mLVRhNqwaGW0+cJY4QAe4IJ11GAtvM8+i+Ac2kwcYjaQXYuWxA==", "2038ecdf-7e4d-4df1-a2f7-0449f3d2788f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3894078d-6caa-4c84-88cd-75e724e3f4ba", "AQAAAAIAAYagAAAAEKK0pbxbNGxM9wrYiBxCZuTRS5vKNuA30N4apXYnbImU0Lmmw4eggIFxaFSG2x6TyQ==", "562b4310-b1ce-4bb4-b01c-d6a5d93b0326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91fe0966-33cd-48f2-aacb-baebdc4e099b", "AQAAAAIAAYagAAAAEOmED+LnXDXfcDTrTQ3uSq2MlhRHguEaQiSSkxt45WQJUsBOEKs43EAM5uefTB+dCQ==", "194f4489-6e09-47bb-bc48-fd26ee0d65b2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 859, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 859, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 859, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 859, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 859, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 859, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 27, 48, 860, DateTimeKind.Local).AddTicks(74));
        }
    }
}
