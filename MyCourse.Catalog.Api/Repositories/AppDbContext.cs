using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using MyCourse.Catalog.Api.Features.Categories;
using MyCourse.Catalog.Api.Features.Courses;
using System.Reflection;

namespace MyCourse.Catalog.Api.Repositories
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }





    }
}
