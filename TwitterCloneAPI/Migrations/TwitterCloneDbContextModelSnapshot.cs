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

                    b.Property<string>("Text")
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
                            Text = "prufa comment",
                            Timestamp = new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7614),
                            TweetId = 1,
                            UserId = 1
                        },
                        new
                        {
                            CommentId = 2,
                            Text = "prufa comment2",
                            Timestamp = new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7633),
                            TweetId = 2,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 3,
                            Text = "prufa comment3",
                            Timestamp = new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7642),
                            TweetId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LikeId"));

                    b.Property<int>("TweetId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LikeId");

                    b.HasIndex("TweetId");

                    b.ToTable("Likes");

                    b.HasData(
                        new
                        {
                            LikeId = 1,
                            TweetId = 1,
                            UserId = 1
                        },
                        new
                        {
                            LikeId = 2,
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
                            Text = "This is my first tweet",
                            Timestamp = new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7577),
                            UserId = 2
                        },
                        new
                        {
                            TweetId = 2,
                            Text = "Tweet number two is here",
                            Timestamp = new DateTime(2023, 1, 4, 15, 25, 45, 257, DateTimeKind.Local).AddTicks(7604),
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

                    b.Property<string>("Handle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Donald J.",
                            Handle = "@realDonaldTrump",
                            LastName = "Trump"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Elon",
                            Handle = "@elonmusk",
                            LastName = "Musk"
                        },
                        new
                        {
                            UserId = 3,
                            FirstName = "Barack",
                            Handle = "@BarackObama",
                            LastName = "Obama"
                        });
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Comment", b =>
                {
                    b.HasOne("TwitterCloneAPI.Models.Tweet", null)
                        .WithMany("Comments")
                        .HasForeignKey("TweetId");

                    b.HasOne("TwitterCloneAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TwitterCloneAPI.Models.Like", b =>
                {
                    b.HasOne("TwitterCloneAPI.Models.Tweet", null)
                        .WithMany("Likes")
                        .HasForeignKey("TweetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
