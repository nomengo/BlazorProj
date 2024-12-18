namespace BlazorStajApplication.Infrastructure.Persistence
{
    using BlazorStajApplication.Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet Tanımlamaları
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<EmployeeAttribute> Attributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Employee ve Attribute arasındaki ilişkisi (One-to-Many)
            modelBuilder.Entity<EmployeeAttribute>()
                .HasOne(a => a.Employee) // Her Attribute bir Employee'ye ait
                .WithMany(e => e.Attributes) // Her Employee'nin birden fazla Attribute'u olabilir
                .HasForeignKey(a => a.EmployeeId) // Foreign Key tanımı
                .OnDelete(DeleteBehavior.Cascade); // Employee silindiğinde Attribute'ları da sil

            // Project ile Employee arasında One-to-Many ilişki
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Project) // Bir Employee'nin bir Project'i olabilir
                .WithMany(p => p.Employees) // Bir Project birden fazla Employee'ye sahip olabilir
                .HasForeignKey(e => e.ProjectId) // Foreign Key
                .OnDelete(DeleteBehavior.SetNull); // Çalışan, proje kaldırıldığında null yapılır

            // Task ve Employee arasındaki ilişki
            modelBuilder.Entity<Tasks>()
                .HasOne(t => t.AssignedEmployee)
                .WithMany()
                .HasForeignKey(t => t.AssignedEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attendance ve Employee arasındaki ilişki
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Salary ve Employee arasındaki ilişki
            modelBuilder.Entity<Salary>()
                .HasOne(s => s.Employee)
                .WithMany()
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }

}
