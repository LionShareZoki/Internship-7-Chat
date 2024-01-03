using Chat.Data.Models;
using Chat.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using Chat.Data.Utilities;

namespace Chat.Data.Context
{
    public static class DChatSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            string hashedPassword1 = PasswordUtility.HashPassword("user1password");
            string hashedPassword2 = PasswordUtility.HashPassword("user2password");
            string hashedPassword3 = PasswordUtility.HashPassword("user3password");

            modelBuilder.Entity<Captcha>().HasData(
                new Captcha { CaptchaId = 1, CaptchaString = "ABC123", CreatedAt = DateTime.UtcNow },
                new Captcha { CaptchaId = 2, CaptchaString = "XYZ789", CreatedAt = DateTime.UtcNow },
                new Captcha { CaptchaId = 3, CaptchaString = "QWE456", CreatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<ChannelMember>().HasData(
                new ChannelMember { MembershipId = 1, ChannelId = 1, UserId = 1, JoinedAt = DateTime.UtcNow },
                new ChannelMember { MembershipId = 2, ChannelId = 2, UserId = 2, JoinedAt = DateTime.UtcNow },
                new ChannelMember { MembershipId = 3, ChannelId = 3, UserId = 3, JoinedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<GroupChannel>().HasData(
                new GroupChannel { ChannelId = 1, ChannelName = "General", UserId = 1 },
                new GroupChannel { ChannelId = 2, ChannelName = "Random", UserId = 2 },
                new GroupChannel { ChannelId = 3, ChannelName = "Support", UserId = 3 }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message { MessageId = 1, SenderId = 1, ChannelId = 1, RecipientId = 2, Content = "Hello!", SentAt = DateTime.UtcNow },
                new Message { MessageId = 2, SenderId = 2, ChannelId = 2, RecipientId = 3, Content = "How are you?", SentAt = DateTime.UtcNow },
                new Message { MessageId = 3, SenderId = 3, ChannelId = 3, RecipientId = 1, Content = "Goodbye!", SentAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<ProfileSetting>().HasData(
                new ProfileSetting { SettingId = 1, UserId = 1, SettingType = ProfileSettingsType.ChangePassword, UpdatedAt = DateTime.UtcNow },
                new ProfileSetting { SettingId = 2, UserId = 2, SettingType = ProfileSettingsType.ChangeEmail, UpdatedAt = DateTime.UtcNow },
                new ProfileSetting { SettingId = 3, UserId = 3, SettingType = ProfileSettingsType.Logout, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Statistics>().HasData(
                new Statistics { StatisticId = 1, TotalMessages = 100, AverageMessagesPerUser = 10.5f, AverageMessagesPerChannel = 20.3f, TopUsers = new int[] { 1, 2, 3 } }
            );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Email = "user1@example.com", isAdmin = false, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Password = hashedPassword1},
                new User { UserId = 2, Email = "user2@example.com", isAdmin = false, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Password = hashedPassword2 },
                new User { UserId = 3, Email = "user3@example.com", isAdmin = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Password = hashedPassword3 }
            );

            modelBuilder.Entity<UserManagement>().HasData(
                new UserManagement { ManagementId = 1, AdminUserId = 1, TargetUserId = 2, ActionType = UserManagementAction.PromoteToAdmin, ActionDate = DateTime.UtcNow },
                new UserManagement { ManagementId = 2, AdminUserId = 2, TargetUserId = 3, ActionType = UserManagementAction.ChangeEmail, ActionDate = DateTime.UtcNow },
                new UserManagement { ManagementId = 3, AdminUserId = 3, TargetUserId = 1, ActionType = UserManagementAction.DeleteProfile, ActionDate = DateTime.UtcNow }
            );

            modelBuilder.Entity<UserSession>().HasData(
                new UserSession { UserSessionId = 1, UserId = 1, SessionToken = "token123", ExpiresAt = DateTime.UtcNow.AddDays(7) },
                new UserSession { UserSessionId = 2, UserId = 2, SessionToken = "token456", ExpiresAt = DateTime.UtcNow.AddDays(7) },
                new UserSession { UserSessionId = 3, UserId = 3, SessionToken = "token789", ExpiresAt = DateTime.UtcNow.AddDays(7) }
            );
        }
    }
}
