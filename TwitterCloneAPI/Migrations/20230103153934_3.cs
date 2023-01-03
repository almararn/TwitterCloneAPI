using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterCloneAPI.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "Handle",
                value: "@firstuser");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Handle",
                value: "@seconduser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 25, 13, 967, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 25, 13, 967, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 25, 13, 967, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 25, 13, 967, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2023, 1, 3, 15, 25, 13, 967, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Handle",
                value: "firstuser");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Handle",
                value: "seconduser");
        }
    }
}
