using MyCourse.Catalog.Api.Features.Categories;
using MyCourse.Catalog.Api.Repositories;

namespace MyCourse.Catalog.Api.Features.Courses
{
    public class Course:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal price { get; set; }
        public Guid UserId { get; set; }
        public string? Picture { get; set; }
        public DateTime CreDate { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } =default!;
        public Feature Feature { get; set; } = default!;

    }
}
