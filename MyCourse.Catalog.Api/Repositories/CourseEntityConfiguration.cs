using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;
using MyCourse.Catalog.Api.Features.Courses;
using System.Reflection.Emit;

namespace MyCourse.Catalog.Api.Repositories
{
    public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToCollection("courses");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();
            builder.Property(c => c.Name).HasElementName("name").HasMaxLength(100);
            builder.Property(c => c.Description).HasElementName("description").HasMaxLength(1000);
            builder.Property(c => c.Category).HasElementName("category");
            builder.Property(c => c.UserId).HasElementName("userId");
            builder.Property(c => c.CategoryId).HasElementName("categoryId");
            builder.Property(c => c.Picture).HasElementName("picture");
            builder.Ignore(x => x.Category);

            builder.OwnsOne(c => c.Feature, feature =>
            {

                feature.HasElementName("feature");
                feature.Property(x => x.Duration).HasElementName("duration");
                feature.Property(x => x.Rating).HasElementName("rating");
                feature.Property(x => x.TeacherFullName).HasElementName("teacherFullNameş");

            });
        }
    }
}
