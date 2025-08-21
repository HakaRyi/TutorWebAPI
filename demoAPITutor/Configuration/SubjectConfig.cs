using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demoAPITutor.Configuration
{
    public class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired();

            builder.HasData(new List<Subject>
{
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "English" },
                new Subject { Id = 3, Name = "Science" },
                new Subject { Id = 4, Name = "History" },
                new Subject { Id = 5, Name = "Geography" },
                new Subject { Id = 6, Name = "Physics" },
                new Subject { Id = 7, Name = "Chemistry" },
                new Subject { Id = 8, Name = "Biology" },
                new Subject { Id = 9, Name = "Literature" },
                new Subject { Id = 10, Name = "Civics" },
                new Subject { Id = 11, Name = "Physical Education" },
                new Subject { Id = 12, Name = "Art" },
                new Subject { Id = 13, Name = "Music" },
                new Subject { Id = 14, Name = "Computer Science" },
                new Subject { Id = 15, Name = "Technology" },
                new Subject { Id = 16, Name = "Foreign Language" }
});
        }
    }
}
