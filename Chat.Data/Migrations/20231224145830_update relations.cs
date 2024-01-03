using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Data.Migrations
{
    /// <inheritdoc />
    public partial class updaterelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserManagements",
                type: "integer",
                nullable: true);

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
                columns: new[] { "ActionDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7530), null });

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2,
                columns: new[] { "ActionDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7530), null });

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3,
                columns: new[] { "ActionDate", "UserId" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 58, 29, 836, DateTimeKind.Utc).AddTicks(7530), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserSessions_UserId",
                table: "UserSessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManagements_AdminUserId",
                table: "UserManagements",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManagements_TargetUserId",
                table: "UserManagements",
                column: "TargetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserManagements_UserId",
                table: "UserManagements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSettings_UserId",
                table: "ProfileSettings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileSettings_Users_UserId",
                table: "ProfileSettings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserManagements_Users_AdminUserId",
                table: "UserManagements",
                column: "AdminUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserManagements_Users_TargetUserId",
                table: "UserManagements",
                column: "TargetUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserManagements_Users_UserId",
                table: "UserManagements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSessions_Users_UserId",
                table: "UserSessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileSettings_Users_UserId",
                table: "ProfileSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserManagements_Users_AdminUserId",
                table: "UserManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserManagements_Users_TargetUserId",
                table: "UserManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserManagements_Users_UserId",
                table: "UserManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSessions_Users_UserId",
                table: "UserSessions");

            migrationBuilder.DropIndex(
                name: "IX_UserSessions_UserId",
                table: "UserSessions");

            migrationBuilder.DropIndex(
                name: "IX_UserManagements_AdminUserId",
                table: "UserManagements");

            migrationBuilder.DropIndex(
                name: "IX_UserManagements_TargetUserId",
                table: "UserManagements");

            migrationBuilder.DropIndex(
                name: "IX_UserManagements_UserId",
                table: "UserManagements");

            migrationBuilder.DropIndex(
                name: "IX_ProfileSettings_UserId",
                table: "ProfileSettings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserManagements");

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 1,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 2,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 3,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 1,
                column: "ActionDate",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2,
                column: "ActionDate",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3,
                column: "ActionDate",
                value: new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 3,
                column: "ExpiresAt",
                value: new DateTime(2023, 12, 31, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330), new DateTime(2023, 12, 24, 14, 33, 50, 569, DateTimeKind.Utc).AddTicks(1330) });
        }
    }
}
