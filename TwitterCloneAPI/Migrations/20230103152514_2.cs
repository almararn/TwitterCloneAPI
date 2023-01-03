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
            migrationBuilder.AddColumn<string>(
                name: "Handle",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Handle",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 44, 9, 567, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 44, 9, 567, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 44, 9, 567, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 44, 9, 567, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 44, 9, 567, DateTimeKind.Local).AddTicks(5973));
        }
    }
}
