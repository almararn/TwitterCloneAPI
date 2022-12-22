using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterCloneAPI.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 12, 20, 17, 31, 56, 95, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 12, 20, 17, 31, 56, 95, DateTimeKind.Local).AddTicks(1836));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 12, 19, 15, 46, 37, 898, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 12, 19, 15, 46, 37, 898, DateTimeKind.Local).AddTicks(7330));
        }
    }
}
