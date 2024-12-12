using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using MyCourse.Catalog.Api.Features.Categories;
using MyCourse.Catalog.Api.Features.Courses;

namespace MyCourse.Catalog.Api.Repositories
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().ToCollection("courses");
            modelBuilder.Entity<Course>().HasKey(c => c.Id);
            modelBuilder.Entity<Course>().Property(c => c.Id).ValueGeneratedNever();   
            modelBuilder.Entity<Course>().Property(c => c.Name).HasElementName("name").HasMaxLength(100);   
            modelBuilder.Entity<Course>().Property(c => c.Description).HasElementName("description").HasMaxLength(1000);
            modelBuilder.Entity<Course>().Property(c => c.Category).HasElementName("category");
            modelBuilder.Entity<Course>().Property(c => c.UserId).HasElementName("userId");
            modelBuilder.Entity<Course>().Property(c => c.CategoryId).HasElementName("categoryId");
            modelBuilder.Entity<Course>().Property(c => c.Picture).HasElementName("picture");
            modelBuilder.Entity<Course>().Property(c => c.price).HasElementName("price");



            modelBuilder.Entity<Category>().ToCollection("categories");
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Category>().Property(c => c.Id).ValueGeneratedNever();
            modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(100);


            modelBuilder.Entity<Course>().OwnsOne(c => c.Feature, feature =>
            {

                feature.HasElementName("feature");
                feature.Property(x => x.Duration).HasElementName("duration");
                feature.Property(x => x.Rating).HasElementName("rating");
                feature.Property(x => x.TeacherFullName).HasElementName("teacherFullName");

            });





        }





    }
}
