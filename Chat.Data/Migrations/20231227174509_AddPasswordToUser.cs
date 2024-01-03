using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 1,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 2,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 3,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 1,
                column: "ActionDate",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2,
                column: "ActionDate",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3,
                column: "ActionDate",
                value: new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 3, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 3, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 3,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 3, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8280), "12345678", new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8280), "12345678", new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8280), "12345678", new DateTime(2023, 12, 27, 17, 45, 9, 588, DateTimeKind.Utc).AddTicks(8280) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 1,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 2,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 3,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 1,
                column: "ActionDate",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2,
                column: "ActionDate",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3,
                column: "ActionDate",
                value: new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2023, 12, 31, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2023, 12, 31, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 3,
                column: "ExpiresAt",
                value: new DateTime(2023, 12, 31, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7510), new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7510), new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7520), new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7520) });
        }
    }
}
