using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterCloneAPI.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "FirstName", "Handle", "LastName" },
                values: new object[] { "Donald J.", "@realDonaldTrump", "Trump" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "FirstName", "Handle", "LastName" },
                values: new object[] { "Elon", "@elonmusk", "Musk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 39, 34, 176, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 39, 34, 176, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 39, 34, 176, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 39, 34, 176, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 39, 34, 176, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "FirstName", "Handle", "LastName" },
                values: new object[] { "User1", "@firstuser", "LastName1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "FirstName", "Handle", "LastName" },
                values: new object[] { "User2", "@seconduser", "LastName2" });
        }
    }
}
