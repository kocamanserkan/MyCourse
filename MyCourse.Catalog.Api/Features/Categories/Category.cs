using MyCourse.Catalog.Api.Features.Courses;
using MyCourse.Catalog.Api.Repositories;

namespace MyCourse.Catalog.Api.Features.Categories
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } = default!;
        public List<Course>? Courses {  get; set; }   
    }
}
