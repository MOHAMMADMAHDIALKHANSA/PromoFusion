using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5af94b43-0382-4430-b995-9ea8a74766cf", "AQAAAAIAAYagAAAAEGZA43ej6tXTIgHQ7kL43X7pdH7zN5FSO5QsoTi3u6bbireZPiM/nV3cexUrDRVQdw==", "c5e3dbb3-6c67-4d4e-87e9-97b8f98f7110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d17e128-b530-4550-952a-347ce235f7d6", "AQAAAAIAAYagAAAAELoPh8dzepmgd5rAMg6Sa23db8HAUs6lJW0j9/7JGovN1ayNplcfKRq+MUJb6rARJw==", "c5c866c1-96c4-46c4-9c32-3bc3e3db7105" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34ef757d-2c72-4a86-89c0-2becb75f53cb", "AQAAAAIAAYagAAAAEEw9GCuDAMkyTP9GAQ9kTkQrBU2Oca9ucZBA2hDsnBl/y+TU/zWw89Q3PaTgtbiWiQ==", "469769c6-c3c5-4f48-8f69-7579f2aa527d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c5c389c-4dbc-439c-b7e0-5c6c80fa5f04", "AQAAAAIAAYagAAAAECodqj1kmfg0lF+aqikgQP9LplQG2XMmUvAXOWJeYbW8VFWWo72Ef4+vD2LRq2VDSw==", "cee00312-2aa7-4dd4-9daf-1871cb1e04da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e5565d-3858-4759-99a1-1589d00d7e32", "AQAAAAIAAYagAAAAEEpI/ujNLup/xni80QsFt56e6WA7DE5d1chAaOz+qSoB3AuXC9iLQoCmEZK0R7/hJQ==", "75e7fd22-07fd-488c-9ff2-4dcaad10bafc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44088a07-fdad-4da2-9970-5e5be4ad4c90", "AQAAAAIAAYagAAAAEIubD0rKD0zMr/V+XWbhjGhwCG67Vbwh6a/tkqr+0g+hOAnGpaL72OMsJD6inaGvyw==", "4a8ab3fe-2222-4460-b613-1a375bc1aa1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cfff804-2177-4133-b4e9-2affccb81f79", "AQAAAAIAAYagAAAAEE41GMpCw9b2VBJS0wkjYHb9o8J6e5bEWT9zio8LXxUB5qzEQbDTkeWtkmqtaTFcBw==", "48f1a06a-dab5-472e-8b62-4b4c21475634" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fee905e0-9f7d-4ea5-976e-dee08c2e8bb1", "AQAAAAIAAYagAAAAEEcHNZgnNOclsPEbBho9j0uH11nbP9vPS0fpGpAZCc3e+cwaj7IZ1wgDze5YRsErEQ==", "698c2a82-b99b-4c85-9f52-e2b7629294a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee518e5-590b-4e5f-a395-47d4571aec82", "AQAAAAIAAYagAAAAEDYczogJxp0SkJSGV7y+rlaA7LWWL5IqCcwTqJHmf7MJI100+d9gXMjLtWGHR6gp7g==", "08527dd2-328c-436d-b45a-4972aa09d7d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c2f675a-f318-4e7c-b233-3f86bfc9f0a5", "AQAAAAIAAYagAAAAEPkc1vbFHDBgTBrv0/PWGM3Nm8rJeNR+Qd13k1r3aFHoCrMq2qbjTQtWrxMy1eZjGg==", "99f5fe58-30ab-4af7-929e-ad235b9cffdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e56f7582-4ff7-4ae6-8eca-70c986384989", "AQAAAAIAAYagAAAAELejDU3SNMTwk/sQ4K67f3ygLt6wqlDIheN3iOT0il6l1/Ran5Pusb5I5BvBuxODng==", "65da83f4-88a6-4efb-9084-b487ee3ccaa3" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 54, 26, 359, DateTimeKind.Local).AddTicks(4562));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2208));

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
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6555));

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
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6620));

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
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6702));

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
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6723));

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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Caption", "Content", "CreatedAt", "MarketingAgencyId", "picContent" },
                values: new object[,]
                {
                    { 2, "BeyondFood Post 2", "https://www.youtube.com/watch?v=CevxZvSJLk8", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2201), 1, "https://images.unsplash.com/photo-1556742031-c6961e8560b9" },
                    { 3, "BeyondFood Post 3", "https://www.youtube.com/watch?v=3JZ_D3ELwOQ", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2205), 1, "https://images.unsplash.com/photo-1561047029-3000e62f9c36" },
                    { 5, "BeyondFood Post 5", "https://www.youtube.com/watch?v=V-_O7nl0Ii0", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(2211), 1, "https://images.unsplash.com/photo-1481931715705-36a57477604e" },
                    { 8, "Explorernico Post 3", "https://www.youtube.com/watch?v=hY7m5jjJ9mM", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6543), 2, "https://images.unsplash.com/photo-1536220243043-8f4530d1a174" },
                    { 9, "Explorernico Post 4", "https://www.youtube.com/watch?v=K4TOrB7at0Y", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6546), 2, "https://images.unsplash.com/photo-1536220424265-cd4b86ad0b66" },
                    { 10, "Explorernico Post 5", "https://www.youtube.com/watch?v=60ItHLz5WEA", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6549), 2, "https://images.unsplash.com/photo-1516762689617-30b83c7540d1" },
                    { 12, "Evolve Post 2", "https://www.youtube.com/watch?v=Zi_XLOBDo_Y", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6558), 3, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 13, "Evolve Post 3", "https://www.youtube.com/watch?v=RgKAFK5djSk", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6561), 3, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 16, "Food Couple Post 1", "https://www.youtube.com/watch?v=6_b7RDuLwcI", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6591), 4, "https://images.unsplash.com/photo-1556742400-52b34cb48e20" },
                    { 17, "Food Couple Post 2", "https://www.youtube.com/watch?v=0J2QdDbelmY", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6594), 4, "https://images.unsplash.com/photo-1581320543175-8b32f60b3214" },
                    { 18, "Food Couple Post 3", "https://www.youtube.com/watch?v=1Cw1ng75KP0", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6597), 4, "https://images.unsplash.com/photo-1516763485050-6e068f0f3324" },
                    { 23, "Social Media Queen Post 3", "https://www.youtube.com/watch?v=YQHsXMglC9A", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6612), 5, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 24, "Social Media Queen Post 4", "https://www.youtube.com/watch?v=oHg5SJYRHA0", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6615), 5, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 25, "Social Media Queen Post 5", "https://www.youtube.com/watch?v=fRh_vgS2dFE", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6617), 5, "https://images.unsplash.com/photo-1593642532973-d31b6557fa68" },
                    { 27, "Tech Trendsetter Post 2", "https://www.youtube.com/watch?v=UO_84C3fpuI", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6623), 6, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 28, "Tech Trendsetter Post 3", "https://www.youtube.com/watch?v=ZZ5LpwO-An4", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6625), 6, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" },
                    { 31, "Fitness Freak Post 1", "https://www.youtube.com/watch?v=9bZkp7q19f0", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6681), 7, "https://images.unsplash.com/photo-1556742400-52b34cb48e20" },
                    { 32, "Fitness Freak Post 2", "https://www.youtube.com/watch?v=V-_O7nl0Ii0", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6684), 7, "https://images.unsplash.com/photo-1581320543175-8b32f60b3214" },
                    { 33, "Fitness Freak Post 3", "https://www.youtube.com/watch?v=0J2QdDbelmY", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6687), 7, "https://images.unsplash.com/photo-1516763485050-6e068f0f3324" },
                    { 37, "Travel Junkie Post 2", "https://www.youtube.com/watch?v=3AtDnEC4zak", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6697), 8, "https://images.unsplash.com/photo-1556742031-c6961e8560b9" },
                    { 38, "Travel Junkie Post 3", "https://www.youtube.com/watch?v=CevxZvSJLk8", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6700), 8, "https://images.unsplash.com/photo-1561047029-3000e62f9c36" },
                    { 40, "Travel Junkie Post 5", "https://www.youtube.com/watch?v=60ItHLz5WEA", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6708), 8, "https://images.unsplash.com/photo-1481931715705-36a57477604e" },
                    { 43, "Style Guru Post 3", "https://www.youtube.com/watch?v=hY7m5jjJ9mM", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6715), 9, "https://images.unsplash.com/photo-1536220243043-8f4530d1a174" },
                    { 44, "Style Guru Post 4", "https://www.youtube.com/watch?v=K4TOrB7at0Y", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6718), 9, "https://images.unsplash.com/photo-1536220424265-cd4b86ad0b66" },
                    { 45, "Style Guru Post 5", "https://www.youtube.com/watch?v=60ItHLz5WEA", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6721), 9, "https://images.unsplash.com/photo-1516762689617-30b83c7540d1" },
                    { 47, "Gaming Enthusiast Post 2", "https://www.youtube.com/watch?v=Zi_XLOBDo_Y", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6726), 10, "https://images.unsplash.com/photo-1549921296-3a6b5cb03f6c" },
                    { 48, "Gaming Enthusiast Post 3", "https://www.youtube.com/watch?v=RgKAFK5djSk", new DateTime(2024, 6, 30, 14, 45, 15, 958, DateTimeKind.Local).AddTicks(6728), 10, "https://images.unsplash.com/photo-1585079541686-b7bff75e4067" }
                });
        }
    }
}
