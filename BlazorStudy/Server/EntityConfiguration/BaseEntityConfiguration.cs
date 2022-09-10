namespace BlazorStudy.Server;

public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.Id).HasValueGenerator<GuidValueGenerator>();

        builder.Property(x=>x.CreationTime).HasDefaultValueSql("getdate()");

    }
}
