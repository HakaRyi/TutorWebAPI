using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demoAPITutor.Configuration
{
    public class PostDetailConfig : IEntityTypeConfiguration<PostDetail>
    {
        public void Configure(EntityTypeBuilder<PostDetail> builder)
        {
            builder.ToTable("PostDetail");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Address).IsRequired();
        }
    }
}
