﻿// <auto-generated />
using System;
using Chat.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Chat.Data.Migrations
{
    [DbContext(typeof(ChatAppContext))]
    [Migration("20231224143350_update time")]
    partial class updatetime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Chat.Data.Models.Captcha", b =>
                {
                    b.Property<int>("CaptchaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CaptchaId"));

                    b.Property<string>("CaptchaString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CaptchaId");

                    b.ToTable("Captchas");

                    b.HasData(
                        new
                        {
                            CaptchaId = 1,
                            CaptchaString = "ABC123",
                            CreatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180)
                        },
                        new
                        {
                            CaptchaId = 2,
                            CaptchaString = "XYZ789",
                            CreatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180)
                        },
                        new
                        {
                            CaptchaId = 3,
                            CaptchaString = "QWE456",
                            CreatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180)
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.ChannelMember", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MembershipId"));

                    b.Property<int>("ChannelId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("JoinedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("MembershipId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserId");

                    b.ToTable("ChannelMembers");

                    b.HasData(
                        new
                        {
                            MembershipId = 1,
                            ChannelId = 1,
                            JoinedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240),
                            UserId = 1
                        },
                        new
                        {
                            MembershipId = 2,
                            ChannelId = 2,
                            JoinedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240),
                            UserId = 2
                        },
                        new
                        {
                            MembershipId = 3,
                            ChannelId = 3,
                            JoinedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240),
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.GroupChannel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChannelId"));

                    b.Property<string>("ChannelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ChannelId");

                    b.ToTable("GroupChannels");

                    b.HasData(
                        new
                        {
                            ChannelId = 1,
                            ChannelName = "General",
                            UserId = 1
                        },
                        new
                        {
                            ChannelId = 2,
                            ChannelName = "Random",
                            UserId = 2
                        },
                        new
                        {
                            ChannelId = 3,
                            ChannelName = "Support",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageId"));

                    b.Property<int>("ChannelId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RecipientId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MessageId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            ChannelId = 1,
                            Content = "Hello!",
                            RecipientId = 2,
                            SenderId = 1,
                            SentAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270)
                        },
                        new
                        {
                            MessageId = 2,
                            ChannelId = 2,
                            Content = "How are you?",
                            RecipientId = 3,
                            SenderId = 2,
                            SentAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270)
                        },
                        new
                        {
                            MessageId = 3,
                            ChannelId = 3,
                            Content = "Goodbye!",
                            RecipientId = 1,
                            SenderId = 3,
                            SentAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270)
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.ProfileSetting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SettingId"));

                    b.Property<int>("SettingType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("SettingId");

                    b.ToTable("ProfileSettings");

                    b.HasData(
                        new
                        {
                            SettingId = 1,
                            SettingType = 0,
                            UpdatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290),
                            UserId = 1
                        },
                        new
                        {
                            SettingId = 2,
                            SettingType = 1,
                            UpdatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290),
                            UserId = 2
                        },
                        new
                        {
                            SettingId = 3,
                            SettingType = 3,
                            UpdatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290),
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.Statistics", b =>
                {
                    b.Property<int>("StatisticId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatisticId"));

                    b.Property<float>("AverageMessagesPerChannel")
                        .HasColumnType("real");

                    b.Property<float>("AverageMessagesPerUser")
                        .HasColumnType("real");

                    b.Property<int[]>("TopUsers")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("TotalMessages")
                        .HasColumnType("integer");

                    b.HasKey("StatisticId");

                    b.ToTable("Statistics");

                    b.HasData(
                        new
                        {
                            StatisticId = 1,
                            AverageMessagesPerChannel = 20.3f,
                            AverageMessagesPerUser = 10.5f,
                            TopUsers = new[] { 1, 2, 3 },
                            TotalMessages = 100
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("boolean");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330),
                            Email = "user1@example.com",
                            UpdatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330),
                            isAdmin = false
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330),
                            Email = "user2@example.com",
                            UpdatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330),
                            isAdmin = false
                        },
                        new
                        {
                            UserId = 3,
                            CreatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330),
                            Email = "user3@example.com",
                            UpdatedAt = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330),
                            isAdmin = true
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.UserManagement", b =>
                {
                    b.Property<int>("ManagementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ManagementId"));

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ActionType")
                        .HasColumnType("integer");

                    b.Property<int>("AdminUserId")
                        .HasColumnType("integer");

                    b.Property<int>("TargetUserId")
                        .HasColumnType("integer");

                    b.HasKey("ManagementId");

                    b.ToTable("UserManagements");

                    b.HasData(
                        new
                        {
                            ManagementId = 1,
                            ActionDate = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1340),
                            ActionType = 5,
                            AdminUserId = 1,
                            TargetUserId = 2
                        },
                        new
                        {
                            ManagementId = 2,
                            ActionDate = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1350),
                            ActionType = 4,
                            AdminUserId = 2,
                            TargetUserId = 3
                        },
                        new
                        {
                            ManagementId = 3,
                            ActionDate = new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1350),
                            ActionType = 3,
                            AdminUserId = 3,
                            TargetUserId = 1
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.UserSession", b =>
                {
                    b.Property<int>("UserSessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserSessionId"));

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserSessionId");

                    b.ToTable("UserSessions");

                    b.HasData(
                        new
                        {
                            UserSessionId = 1,
                            ExpiresAt = new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1360),
                            SessionToken = "token123",
                            UserId = 1
                        },
                        new
                        {
                            UserSessionId = 2,
                            ExpiresAt = new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1370),
                            SessionToken = "token456",
                            UserId = 2
                        },
                        new
                        {
                            UserSessionId = 3,
                            ExpiresAt = new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1370),
                            SessionToken = "token789",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Chat.Data.Models.ChannelMember", b =>
                {
                    b.HasOne("Chat.Data.Models.GroupChannel", null)
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Chat.Data.Models.Message", b =>
                {
                    b.HasOne("Chat.Data.Models.GroupChannel", null)
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}