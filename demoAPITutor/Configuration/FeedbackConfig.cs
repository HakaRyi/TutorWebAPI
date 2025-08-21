using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;

namespace demoAPITutor.Configuration
{
    public class FeedbackConfig : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable("Feedback");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
        }
    }
}
