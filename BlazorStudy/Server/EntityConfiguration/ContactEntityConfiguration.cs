namespace BlazorStudy.Server;

public class ContactEntityConfiguration:BaseEntityConfiguration<Contact>,IEntityTypeConfiguration<Contact>
{
    public override void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");

        builder.HasIndex(x => x.PhoneNumber).IsUnique();
        builder.Property(x => x.ContactType).IsRequired();

        builder.HasOne(x=>x.User).WithMany().HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.Cascade);

        base.Configure(builder);
    }
}
