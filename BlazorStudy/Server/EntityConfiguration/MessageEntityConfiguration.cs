namespace BlazorStudy.Server.EntityConfiguration
{
    public class MessageEntityConfiguration:BaseEntityConfiguration<Message>,IEntityTypeConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");

            builder.Property(x=>x.MessageText).IsRequired();
            builder.Property(x => x.MessageText).HasMaxLength(2000);

            builder.HasOne(e => e.FromUser).WithMany().HasForeignKey(e => e.FromUserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.ToUser).WithMany().HasForeignKey(e => e.ToUserId).OnDelete(DeleteBehavior.NoAction);

            base.Configure(builder);
        }
    }
}
