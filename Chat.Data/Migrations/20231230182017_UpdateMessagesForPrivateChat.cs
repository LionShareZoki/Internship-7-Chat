using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMessagesForPrivateChat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_GroupChannels_ChannelId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "RecipientId",
                table: "Messages",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ChannelId",
                table: "Messages",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Captchas",
                keyColumn: "CaptchaId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 1,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 2,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "ChannelMembers",
                keyColumn: "MembershipId",
                keyValue: 3,
                column: "JoinedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ProfileSettings",
                keyColumn: "SettingId",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 1,
                column: "ActionDate",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 2,
                column: "ActionDate",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "UserManagements",
                keyColumn: "ManagementId",
                keyValue: 3,
                column: "ActionDate",
                value: new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 6, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 6, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "UserSessions",
                keyColumn: "UserSessionId",
                keyValue: 3,
                column: "ExpiresAt",
                value: new DateTime(2024, 1, 6, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5730), "BB6700A679B9F4CE6F050FDBC91E100ACF5DBF27E6A6CED9080CC88C9409FCFF_C52C56ACCA62BBEF958F1565D73B9C31_100000", new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5730), "E934B8E9F43E0E3FE5FE6032279FEB33AED350F0C47BD65D70FCE90019E45DC3_453B1CDA7ABF825A6BBB9AFB42B55083_100000", new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5740), "9E6734F6AEDE9CE5E4636606095B082918FC6943B5DB47B8A0D7B34F4B5622BD_C3E594488541C063ED446ADB886F1C98_100000", new DateTime(2023, 12, 30, 18, 20, 17, 675, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_GroupChannels_ChannelId",
                table: "Messages",
                column: "ChannelId",
                principalTable: "GroupChannels",
                principalColumn: "ChannelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_GroupChannels_ChannelId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "RecipientId",
                table: "Messages",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChannelId",
                table: "Messages",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_GroupChannels_ChannelId",
                table: "Messages",
                column: "ChannelId",
                principalTable: "GroupChannels",
                principalColumn: "ChannelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
