using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterCloneAPI.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "Handle", "LastName" },
                values: new object[] { 3, "Barack", "@BarackObama", "Obama" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 42, 31, 231, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 42, 31, 231, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 42, 31, 231, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 42, 31, 231, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 42, 31, 231, DateTimeKind.Local).AddTicks(518));
        }
    }
}
