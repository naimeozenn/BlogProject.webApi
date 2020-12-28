using BlogProject.Entities.Interfaces;
using System.Collections.Generic;

namespace BlogProject.Entities.Concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }

    }
}
