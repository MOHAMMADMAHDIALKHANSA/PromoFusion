using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2e856232-4da0-4273-9043-57f6489ae214", "AQAAAAIAAYagAAAAEFsZaWqwbwlfBRfM10cgkcWrEUtAALr2uNVXJQID8Tx4U2nK4LoDYIiTLZfDbaypsg==", "2bcac7ee-8e5e-4526-a2e8-94e4961e923f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00acf950-ba75-4997-9927-3fb3484f3f28", "AQAAAAIAAYagAAAAECLbaKnpB2HraPci9wTh213/VOc6xfq9Ea87ktl/Zp3GVrRSVjKTRamcEjIzC+EemQ==", "dd1eaa61-144b-4a62-917a-2d8e6938904f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57497f62-c8d1-485d-aa27-a0b77a62265a", "AQAAAAIAAYagAAAAECOtzDoBYPbsHL1C7aYsgADgLBBM76RHUNig5ltE9JHGZj+8/SjwdU3sEdJYWVqlQw==", "f884acc6-6d71-4632-bb7d-6762ff8a692b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca266dd6-b212-4de5-8458-63e6cc2a7aae", "AQAAAAIAAYagAAAAEOWSZlpu3wzy1U7mcFAGDOS7cVgpu3rl2BT7tFNhkDMim0cmjQB0WVqcyX1ClJ3gSg==", "14cb0c04-c5ce-43a6-9c0d-cd2a500e6a4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32206e0b-b36c-4570-8fca-32ab3634097f", "AQAAAAIAAYagAAAAEDOlYuxp2V1hnn+8KxRd62oxZ+gqXo64IKULc+egpgpYpMhclycqkwLjwbDPcelcQA==", "341404b0-89b9-493c-bc82-4aec6184e1c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c61fbe30-eb90-448c-b5e0-f146f9797200", "AQAAAAIAAYagAAAAEBp9SRbDljyqrdClkgm/mFhUs4vGVZDOSb/NsXyacqwhqN/lJ91mPHQo6myA69XOIw==", "28be2164-5757-45cb-8528-05f49d087212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ec8a3d3-2fa7-428f-8bbc-3f59992d093c", "AQAAAAIAAYagAAAAEHraQ+aOnyiBjwqjkTxdYLuVgdJJLdV7oE0TSHjiuRpnL37HwivQz6xkC9Y3y9evUw==", "3e81089e-5342-472a-b3ab-714c9d49299b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9913b84f-9484-4ec0-890b-af17f25c703d", "AQAAAAIAAYagAAAAEDtB+3YAEX1b39INKEqTX9E/EnWJBTV8zGt9U8uvQhbP+LYojpXjyOUsdm/3ElxpDQ==", "8ef2f711-1ca8-4371-8a02-20ab29543dd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5217f1c-afbd-4bbe-8219-643ecb7ea5a7", "AQAAAAIAAYagAAAAEN4psJ0Gwwy+kPkLMLuBkKRlkixKn5a68n6FvrOobWPw7o39MUd/leaRO+c05gNM1g==", "c7bb191b-35bd-4539-ba16-6ecc95c9c794" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49ba3c8-8019-462e-a1cd-2dcb1349eda4", "AQAAAAIAAYagAAAAEPO/ADlSZCKs9yLCcAQVdEueD7RKrx/h/6NyoUugAAJ4D+VNw592nazYpvT2WksTQQ==", "cf9bc423-b24d-44aa-a3d1-d45dd127539e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cee8c9b4-b101-4de9-8797-78bbbe55ea95", "AQAAAAIAAYagAAAAELsU/utlqfLDKMe00aq1o1R7ONs2HSZqczkW2UoAi/7WVoZEdoR9u0MXYDjHC+PjQw==", "0a8cb024-a9cb-4430-ae33-5d1223c97405" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 35, 15, 357, DateTimeKind.Local).AddTicks(1250));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
