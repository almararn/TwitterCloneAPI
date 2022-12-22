using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwitterCloneAPI.Migrations
{
    /// <inheritdoc />
    public partial class Int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tweets",
                columns: table => new
                {
                    TweetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Retweet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Like = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweets", x => x.TweetId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TweetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Tweets_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweets",
                        principalColumn: "TweetId");
                });

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "TweetId", "Comment", "Like", "Retweet", "Text", "Timestamp" },
                values: new object[,]
                {
                    { 1, "first comment", "User4", "User4", "This is my first tweet", new DateTime(2022, 12, 19, 15, 46, 37, 898, DateTimeKind.Local).AddTicks(7315) },
                    { 2, "nice tweet", "User1", "User4", "Tweet number two is here, making it a little bit longer than the first one. Few lines more. Just adding some text to make it to the third line of the user intrerface.", new DateTime(2022, 12, 19, 15, 46, 37, 898, DateTimeKind.Local).AddTicks(7330) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "TweetId" },
                values: new object[] { 1, "User1", "LastName1", null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TweetId",
                table: "Users",
                column: "TweetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tweets");
        }
    }
}
