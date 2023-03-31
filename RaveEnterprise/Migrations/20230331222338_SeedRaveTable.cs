using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RaveEnterprise.Migrations
{
    /// <inheritdoc />
    public partial class SeedRaveTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Raves",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Raves",
                columns: new[] { "Id", "Brand", "CreatedDate", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " It has a strong resemblance with Java, it has numerous strong programming features that make it endearing to a number of programmers worldwide. Following is the list of a few important features ", "Core Purple Boot", "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "There are no prerequisites required to learn C#.NET as we are going to start from the very basics. It is good to have .NET Framework and Visual Studio installed on your computer, as it might assist you in executing the examples yourself and getting to know how it works.", "Core Purple Boot", "https://www.pexels.com/photo/palm-trees-at-night-258154/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Redis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen", "Core Red Boot", "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/", 18999L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " It has a strong resemblance with Java, it has numerous strong programming features that make it endearing to a number of programmers worldwide. Following is the list of a few important features ", "Core Purple Boot", "https://www.pexels.com/photo/palm-trees-at-night-258154/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "DELL G5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "There are no prerequisites required to learn C#.NET as we are going to start from the very basics. It is good to have .NET Framework and Visual Studio installed on your computer, as it might assist you in executing the examples yourself and getting to know how it works.", "Angular Blue Boot", "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/", 430000L, 100, "Angular", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "DELL G5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen", "Angular Blue Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/", 430000L, 100, "Angular", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Net Core", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "There are no prerequisites required to learn C#.NET as we are going to start from the very basics. It is good to have .NET Framework and Visual Studio installed on your computer, as it might assist you in executing the examples yourself and getting to know how it works.", "Core Purple Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/", 17990L, 100, "Boot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Raves",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Raves");
        }
    }
}
