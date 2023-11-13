using Microsoft.EntityFrameworkCore;
using OcampoITELEC1C.Models;

namespace OcampoITELEC1C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(

                new Student()
                {
                    Id = 1,
                    FirstName = "Gabriel",
                    LastName = "Montano",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-08-26"),
                    GPA = 1.5,
                    Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Zyx",
                    LastName = "Montano",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Aerdriel",
                    LastName = "Montano",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "aerdriel@gmail.com"
                });

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Gabriel",
                    LastName = "Montano",
                    IsTenured = "Permanent",
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("2020-09-11")
                },
            new Instructor()
            {
                Id = 2,
                FirstName = "Lebron",
                LastName = "James",
                IsTenured = "Probationary",
                Rank = Rank.Instructor,
                HiringDate = DateTime.Parse("2023-09-11")
            },
            new Instructor()
            {
                Id = 3,
                FirstName = "Jessamine",
                LastName = "Lyndon",
                IsTenured = "Probationary",
                Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("2023-09-11")
            },
            new Instructor()
            {
                Id = 4,
                FirstName = "Marje",
                LastName = "Algernon",
                IsTenured = "Permanent",
                Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("2021-05-20")
            }
                ); ;

        }

    }
}
