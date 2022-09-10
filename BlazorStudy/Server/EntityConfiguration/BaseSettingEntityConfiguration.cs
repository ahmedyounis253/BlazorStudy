namespace BlazorStudy.Server;

public class BaseSettingEntityConfiguration<TEntity>:BaseEntityConfiguration<TEntity>,IEntityTypeConfiguration<TEntity> where TEntity : BaseSettingEntity
{
    public virtual new  void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(50);
        builder.Property(x => x.NameSecondLanguage).HasMaxLength(50);
        
        
        builder.Property(x => x.Name).IsRequired();

        base.Configure(builder);
    }
}
