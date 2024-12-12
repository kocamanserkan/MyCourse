using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;
using MyCourse.Catalog.Api.Features.Categories;
using System.Reflection.Emit;

namespace MyCourse.Catalog.Api.Repositories
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

           builder.ToCollection("categories");
           builder.HasKey(c => c.Id);
           builder.Property(c => c.Id).ValueGeneratedNever();
           builder.Property(c => c.Name).HasMaxLength(100);
           builder.Ignore(c => c.Courses);

        }
    }
}
