namespace EFCoreCodeFirst.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using static DataValidations.Student;
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DataSettings.DefaultConnection);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tuk opisvame relations 
            modelBuilder
                .Entity<Student>(entity =>
                {
                    entity.HasKey(e => e.StudentId);
                    entity.ToTable("Students");
                    entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(NameMaxLenght);
                });
        }
    }
}
