using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-353N469\\SQLEXPRESS;Database=CSharpB14;User Id=csharplogin;Password=123456;TrustServerCertificate=True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseStudent>().HasKey((x) => new { x.CourseId, x.StudentId });
            modelBuilder.Entity<Course>().HasIndex(x => x.Name);
            modelBuilder.Entity<Course>()
                .HasMany(x => x.CourseTopics)
                .WithOne(x => x.TopicCourse)
                .HasForeignKey(x => x.CourseId);

            modelBuilder.Entity<CourseStudent>()
                .HasOne(x => x.Course)
                .WithMany(x => x.CourseStudents);
            modelBuilder.Entity<CourseStudent>()
                .HasOne(x => x.Student)
                .WithMany(x => x.StudentCourses);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
