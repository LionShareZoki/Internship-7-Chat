using Microsoft.EntityFrameworkCore;
using Chat.Data.Models;


namespace Chat.Data.Context
{
    public class ChatAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserManagement> UserManagements { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<ProfileSetting> ProfileSettings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<GroupChannel> GroupChannels { get; set; }
        public DbSet<ChannelMember> ChannelMembers { get; set; }
        public DbSet<Captcha> Captchas { get; set; }

        public ChatAppContext(DbContextOptions<ChatAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<User>().HasKey(u => u.UserId);
    modelBuilder.Entity<UserManagement>().HasKey(um => um.ManagementId);
    modelBuilder.Entity<UserSession>().HasKey(us => us.UserSessionId);
    modelBuilder.Entity<Statistics>().HasKey(s => s.StatisticId);
    modelBuilder.Entity<ProfileSetting>().HasKey(ps => ps.SettingId);
    modelBuilder.Entity<Message>().HasKey(m => m.MessageId);
    modelBuilder.Entity<GroupChannel>().HasKey(gc => gc.ChannelId);
    modelBuilder.Entity<ChannelMember>().HasKey(cm => cm.MembershipId);
    modelBuilder.Entity<Captcha>().HasKey(c => c.CaptchaId);
    

    modelBuilder.Entity<User>()
        .Property(u => u.isAdmin);

    modelBuilder.Entity<Message>()
        .HasOne<User>()
        .WithMany()
        .HasForeignKey(m => m.SenderId);

    modelBuilder.Entity<Message>()
        .HasOne<GroupChannel>()
        .WithMany()
        .HasForeignKey(m => m.ChannelId);

    modelBuilder.Entity<ChannelMember>()
        .HasOne<GroupChannel>()
        .WithMany()
        .HasForeignKey(cm => cm.ChannelId);

    modelBuilder.Entity<ChannelMember>()
        .HasOne<User>()
        .WithMany()
        .HasForeignKey(cm => cm.UserId);


    modelBuilder.Entity<User>()
        .HasIndex(u => u.Email)
        .IsUnique();

    modelBuilder.Entity<User>()
        .Property(u => u.isAdmin);

    modelBuilder.Entity<UserSession>()
        .HasOne<User>(us => us.User)
        .WithMany(u => u.UserSessions)
        .HasForeignKey(us => us.UserId);

    // User to ProfileSettings
    modelBuilder.Entity<ProfileSetting>()
        .HasOne<User>(ps => ps.User)
        .WithMany(u => u.ProfileSettings)
        .HasForeignKey(ps => ps.UserId);

    modelBuilder.Entity<UserManagement>()
        .HasOne(um => um.AdminUser)
        .WithMany()
        .HasForeignKey(um => um.AdminUserId);

    modelBuilder.Entity<UserManagement>()
        .HasOne(um => um.TargetUser)
        .WithMany()
        .HasForeignKey(um => um.TargetUserId);

    DChatSeeder.Seed(modelBuilder);
        }

    }
}