using demoAPITutor.Configuration;
using demoAPITutor.Models;
using Microsoft.EntityFrameworkCore;

namespace demoAPITutor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<TutorProfile> TutorProfiles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TutorSubject> TutorSubjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<TutorGrade> TutorGrades { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostDetail> PostDetails { get; set; }
        public DbSet<Request> Requests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());  
            base.OnModelCreating(modelBuilder);

            // Cấu hình mối quan hệ Many-to-Many giữa User (Tutor) và Grade thông qua TutorGrade

            modelBuilder.Entity<TutorGrade>()
                .HasKey(tg => new { tg.TutorId, tg.GradeId }); // Khóa chính là sự kết hợp của TutorId và GradeId

            // 2. Cấu hình mối quan hệ từ TutorGrade đến User (Tutor)
            modelBuilder.Entity<TutorGrade>()
                .HasOne(tg => tg.Tutor) // TutorGrade có một Tutor
                .WithMany(u => u.TutorGrades) // Tutor có nhiều TutorGrades 
                .HasForeignKey(tg => tg.TutorId); // Khóa ngoại là TutorId

            // 3. Cấu hình mối quan hệ từ TutorGrade đến Grade
            modelBuilder.Entity<TutorGrade>()
                .HasOne(tg => tg.Grade) // TutorGrade có một Grade
                .WithMany(g => g.TutorGrades) // Grade có nhiều TutorGrades
                .HasForeignKey(tg => tg.GradeId); // Khóa ngoại là GradeId



            // Cấu hình mối quan hệ Many-to-Many giữa User (Tutor) và Subject thông qua TutorSubject

            modelBuilder.Entity<TutorSubject>()
                .HasKey(ts => new { ts.TutorId, ts.SubjectId }); // Khóa chính là sự kết hợp của TutorId và SubjectId

            // 2. Cấu hình mối quan hệ từ TutorSubject đến User (Tutor)
            modelBuilder.Entity<TutorSubject>()
                .HasOne(ts => ts.Tutor) 
                .WithMany(u => u.TutorSubjects)
                .HasForeignKey(ts => ts.TutorId);

            // 3. Cấu hình mối quan hệ từ TutorSubject đến Subject
            modelBuilder.Entity<TutorSubject>()
                .HasOne(ts => ts.Subject)  
                .WithMany(s => s.TutorSubjects) 
                .HasForeignKey(ts => ts.SubjectId);

            //Feedback
            // Quan hệ 1-Nhiều giữa User và Feedback (User cho Feedback)
            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Student) // Feedback được cho bởi một User
                .WithMany(u => u.GivenFeedbacks) // User đã cho nhiều Feedbacks
                .HasForeignKey(f => f.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Quan hệ 1-Nhiều giữa User và Feedback (User nhận Feedback)
            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Tutor) // Feedback được nhận bởi một User
                .WithMany(u => u.ReceivedFeedbacks) // User đã nhận nhiều Feedbacks
                .HasForeignKey(f => f.TutorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Student) // Request có một Student
                .WithMany(u => u.SendRequests) // User có nhiều Request được gửi đi (SendRequests)
                .HasForeignKey(r => r.StudentId) // StudentId là khóa ngoại trong Request
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Post) // Request có một Post
                .WithMany(p => p.Requests) // Post có nhiều Requests liên quan đến nó
                .HasForeignKey(r => r.PostId) // PostId là khóa ngoại trong Request
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Receiver) // Request có một Receiver
                .WithMany(u => u.ReceivedRequests) // User có nhiều Request được nhận (ReceivedRequests)
                .HasForeignKey(r => r.ReceiverId) // ReceiverId là khóa ngoại trong Request
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Post) // Request có một Post
                .WithMany(p => p.Requests) // Post có nhiều Requests liên quan đến nó
                .HasForeignKey(r => r.PostId) // PostId là khóa ngoại trong Request
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
