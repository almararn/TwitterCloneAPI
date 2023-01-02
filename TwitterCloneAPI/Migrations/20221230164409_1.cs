using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterCloneAPI.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Likes",
                keyColumn: "LikeId",
                keyValue: 2,
                column: "TweetId",
                value: 1);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 43, 20, 989, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 43, 20, 989, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 43, 20, 989, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "LikeId",
                keyValue: 2,
                column: "TweetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 43, 20, 989, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "TweetId",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 12, 30, 16, 43, 20, 989, DateTimeKind.Local).AddTicks(5237));
        }
    }
}
