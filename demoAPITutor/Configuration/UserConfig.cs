using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demoAPITutor.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(t => t.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x=>x.Username).IsRequired();
            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x=>x.Password).IsRequired();
            builder.Property(t => t.PhoneNumber).IsRequired();
            builder.Property(t => t.Sex).IsRequired();
            builder.Property(t => t.Role).IsRequired();
            builder.Property(t => t.Address).IsRequired();
            builder.Property(t => t.Fullname).IsRequired();
            builder.Property(t => t.Address).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();


        }
    }
}
