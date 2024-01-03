using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chat.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatetime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Captchas",
                columns: new[] { "CaptchaId", "CaptchaString", "CreatedAt" },
                values: new object[,]
                {
                    { 1, "ABC123", new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180) },
                    { 2, "XYZ789", new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180) },
                    { 3, "QWE456", new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180) }
                });

            migrationBuilder.InsertData(
                table: "GroupChannels",
                columns: new[] { "ChannelId", "ChannelName", "UserId" },
                values: new object[,]
                {
                    { 1, "General", 1 },
                    { 2, "Random", 2 },
                    { 3, "Support", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProfileSettings",
                columns: new[] { "SettingId", "SettingType", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290), 1 },
                    { 2, 1, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290), 2 },
                    { 3, 3, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290), 3 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "StatisticId", "AverageMessagesPerChannel", "AverageMessagesPerUser", "TopUsers", "TotalMessages" },
                values: new object[] { 1, 20.3f, 10.5f, new[] { 1, 2, 3 }, 100 });

            migrationBuilder.InsertData(
                table: "UserManagements",
                columns: new[] { "ManagementId", "ActionDate", "ActionType", "AdminUserId", "TargetUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1340), 5, 1, 2 },
                    { 2, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1350), 4, 2, 3 },
                    { 3, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1350), 3, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserSessions",
                columns: new[] { "UserSessionId", "ExpiresAt", "SessionToken", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1360), "token123", 1 },
                    { 2, new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1370), "token456", 2 },
                    { 3, new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1370), "token789", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "UpdatedAt", "isAdmin" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), "user1@example.com", new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), false },
                    { 2, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), "user2@example.com", new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), false },
                    { 3, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), "user3@example.com", new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), true }
                });

            migrationBuilder.InsertData(
                table: "ChannelMembers",
                columns: new[] { "MembershipId", "ChannelId", "JoinedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240), 1 },
                    { 2, 2, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240), 2 },
                    { 3, 3, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240), 3 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "ChannelId", "Content", "RecipientId", "SenderId", "SentAt" },
                values: new object[,]
                {
                    { 1, 1, "Hello!", 2, 1, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270) },
                    { 2, 2, "How are you?", 3, 2, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270) },
                    { 3, 3, "Goodbye!", 1, 3, new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "StatisticId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GroupChannels",
                keyColumn: "ChannelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupChannels",
                keyColumn: "ChannelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GroupChannels",
                keyColumn: "ChannelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
