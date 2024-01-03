using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Chat.Data.Context;

namespace Chat.Data.Context
{
    public class ChatAppContextFactory : IDesignTimeDbContextFactory<ChatAppContext>
    {
        public ChatAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ChatAppContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Chat;Username=postgres;Password=Google.8436");

            return new ChatAppContext(optionsBuilder.Options);
        }
    }

}