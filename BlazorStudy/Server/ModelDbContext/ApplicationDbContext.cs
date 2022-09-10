using BlazorStudy.Server.EntityConfiguration;

namespace BlazorStudy.Server;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration())
                    .ApplyConfiguration(new MessageEntityConfiguration())
                    .ApplyConfiguration(new ContactEntityConfiguration());
    }
}
