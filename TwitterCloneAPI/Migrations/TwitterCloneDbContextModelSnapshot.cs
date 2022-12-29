﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterCloneAPI.Data;

#nullable disable

namespace TwitterCloneAPI.Migrations
{
    [DbContext(typeof(TwitterCloneDbContext))]
    partial class TwitterCloneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TwitterCloneAPI.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TweetId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("TweetId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            CommentText = "prufa comment",
                            Timestamp = new DateTime(2022, 12, 29, 20, 17, 16, 422, DateTimeKind.Local).AddTicks(7459),
                            TweetId = 1,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 2,
                            CommentText = "prufa comment2",
                            Timestamp = new DateTime(2022, 12, 29, 20, 17, 16, 422, DateTimeKind.Local).AddTicks(7497),
                            TweetId = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Tweet", b =>
                {
                    b.Property<int>("TweetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TweetId"));

                    b.Property<string>("Like")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Retweet")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TweetId");

                    b.HasIndex("UserId");

                    b.ToTable("Tweets");

                    b.HasData(
                        new
                        {
                            TweetId = 1,
                            Like = "User4",
                            Retweet = "User4",
                            Text = "This is my first tweet",
                            Timestamp = new DateTime(2022, 12, 29, 20, 17, 16, 422, DateTimeKind.Local).AddTicks(7432),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "User1",
                            LastName = "LastName1"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "User2",
                            LastName = "LastName2"
                        });
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Comment", b =>
                {
                    b.HasOne("TwitterCloneAPI.Models.Tweet", null)
                        .WithMany("Comment")
                        .HasForeignKey("TweetId");

                    b.HasOne("TwitterCloneAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Tweet", b =>
                {
                    b.HasOne("TwitterCloneAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Tweet", b =>
                {
                    b.Navigation("Comment");
                });
#pragma warning restore 612, 618
        }
    }
}
