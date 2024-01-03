using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 1,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 2,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 3,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 1,
                column: "ActionDate",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2,
                column: "ActionDate",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3,
                column: "ActionDate",
                value: new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 3, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 3, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 3,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 3, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9450), "EC3C97C0124ED1B1AD41CC4D5446998991C5972C9BB58CD1B1871513C65C00F2_6394E0763800C24D5889280D075D6509_100000", new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9450), "A7DAA241D9100C46AE838064190C0A5CE42448FE80FF2A4C8B66F60C9D80DE6B_6FE89566FC18BF7C1D14B61EF0E99E3A_100000", new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9460), "B5864D03CBA443B0A6B161ACAEF216444FBF3C964034C8B63F283775A48851C0_D6D8FF8E9CDF31DA067828EB0728433E_100000", new DateTime(2023, 12, 27, 18, 19, 38, 627, DateTimeKind.Utc).AddTicks(9460) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
