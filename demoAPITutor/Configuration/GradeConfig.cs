using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demoAPITutor.Configuration
{
    public class GradeConfig : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grade");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();

            builder.HasData(new List<Grade>()
            {
                    new Grade { Id = 1, Name = "Grade 1" },
                    new Grade { Id = 2, Name = "Grade 2" },
                    new Grade { Id = 3, Name = "Grade 3" },
                    new Grade { Id = 4, Name = "Grade 4" },
                    new Grade { Id = 5, Name = "Grade 5" },
                    new Grade { Id = 6, Name = "Grade 6" },
                    new Grade { Id = 7, Name = "Grade 7" },
                    new Grade { Id = 8, Name = "Grade 8" },
                    new Grade { Id = 9, Name = "Grade 9" },
                    new Grade { Id = 10, Name = "Grade 10" },
                    new Grade { Id = 11, Name = "Grade 11" },
                    new Grade { Id = 12, Name = "Grade 12" }
            });
        }
    }
}
