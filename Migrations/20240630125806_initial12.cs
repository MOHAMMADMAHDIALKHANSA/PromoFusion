using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketingHub.Migrations
{
    /// <inheritdoc />
    public partial class initial12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6e7f228-3551-4e43-9382-60e8df1ac372", "AQAAAAIAAYagAAAAEPrSLu7Hjmu/cIkZZCEXLDvgiOQZ367X9ANfpxGF4PSEm8u58v40geMlrDUYin2fZw==", "f4c3c2f4-6114-4e25-841b-18e87269dd07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09fd845-aec9-43a0-8e61-4625c990e47c", "AQAAAAIAAYagAAAAEBf3iz8fRrDnOZsOaGsVB7bw0/bgV8XB9M3XXluIKbac3porcApWXjV5WSZBxE0A/A==", "8c67e9c8-f045-4b7d-bbda-ac7f535265d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c5ae25e-17b9-4b0d-a87c-06fd4eff5698", "AQAAAAIAAYagAAAAEHJf81y4VOeV+GwBjavd/AZUP2IMlNLYs9K7acpjSIOV5ktxLxH24Ioqq31IqCpkng==", "07a26e53-059c-4d8c-bc71-cd80af12ebad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9040f48-3f9f-4c43-b887-98f38c4eae59", "AQAAAAIAAYagAAAAEHEMincuAglQboMmpTIEomSRVbBed0s3n67ztK1K8XXUKO6rd2YCnneDyrIfYw14FA==", "c75cee59-67fa-489f-ab98-e32413441177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215f5c66-3b2b-455b-9cb1-373261c13040", "AQAAAAIAAYagAAAAEMaYDjOemCQ9znSC3JoHrn1iBowwvJ2CXo3aP5t+2IKEOsSzHLgKX6causs83I2JTA==", "4d7a9d88-6e8d-4ff9-a96a-5fa408cf03ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6817969-c440-449b-a9d4-50fd0b77fbb2", "AQAAAAIAAYagAAAAEAJGJNFCiCYRqPjO44qjuvSY21NTvlae6bsCme9iRMppyxlNov21aBp0bzTGjBmgnw==", "8631ec9d-af2a-4ed0-b78e-0c628a0d1124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99e35d35-1a0f-4011-9da4-c7c27c5e3a75", "AQAAAAIAAYagAAAAEGIz4tK0UJn56TlxlAa+d96VfaR/sfJC9CLd9hfsup1eN2y0ZvTWNqowrCxB7scu+w==", "26d84214-e0ae-48db-90f4-4c5875125fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58024e2a-7905-432a-b4db-4264beb8ddd1", "AQAAAAIAAYagAAAAEMXPYQpnU4Mi0yVYQdTXXCi7rQhXiyrmRNbwZoERM3cVz8/6QB0y3OvXTmzV8hDH/w==", "aa281040-778f-4751-944a-d11885dee392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c1f0d19-1c98-47e3-b322-a86fcbee1e21", "AQAAAAIAAYagAAAAEAREXfWDq7WTPjI4k3w00Jp4E0wNJ8w4flwutpk9yWfTGDTPl7c5+tj7V+ojWR8IPQ==", "13eb1c0d-86c7-4d04-9712-ba81b6d43ed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3caa58e6-7895-41b6-b5e7-d0fc4b25ac1e", "AQAAAAIAAYagAAAAEPM3YaTPBZSTf8F0AcQ05Vh4Xf52a78Jlj8Uk5XDNZ5TaBdfZeRrYLPqXJW1BmYrkA==", "d9ce9e68-c551-42bf-96b6-769b1a6f698c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9caa547d-441a-4e40-862e-544115e99352", "AQAAAAIAAYagAAAAEKomAwRzPR7VqGKxpP/jisZlOp88c3tzBgFv348BH+W3PQq5saGyxOLawdvC5ABE0w==", "52c4b859-a931-412b-9c57-4e1d75139307" });

            migrationBuilder.InsertData(
                table: "MarketingAgencyCategory",
                columns: new[] { "CategoryId", "MarketingAgencyId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 3, 9 },
                    { 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "MarketingAgencyContractTypes",
                columns: new[] { "ContractTypeId", "MarketingAgencyId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 3, 9 },
                    { 1, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 30, 15, 58, 4, 708, DateTimeKind.Local).AddTicks(4928));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyCategory",
                keyColumns: new[] { "CategoryId", "MarketingAgencyId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "MarketingAgencyContractTypes",
                keyColumns: new[] { "ContractTypeId", "MarketingAgencyId" },
                keyValues: new object[] { 1, 10 });

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
    }
}
