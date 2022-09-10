namespace BlazorStudy.Server;

public class UserEntityConfiguration:BaseEntityConfiguration<User>,IEntityTypeConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasIndex(u => u.EmailAddress).IsUnique();
        
        builder.Property(x => x.EmailAddress).IsRequired();
        builder.Property(x => x.Password).IsRequired();


        base.Configure(builder);
    }

    
}
