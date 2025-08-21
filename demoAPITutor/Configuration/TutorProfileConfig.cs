using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demoAPITutor.Configuration
{
    public class TutorProfileConfig : IEntityTypeConfiguration<TutorProfile>
    {
        public void Configure(EntityTypeBuilder<TutorProfile> builder)
        {
            builder.ToTable("TutorProfile");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
