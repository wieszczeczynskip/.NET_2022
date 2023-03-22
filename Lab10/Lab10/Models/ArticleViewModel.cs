using Microsoft.AspNetCore.Http;

namespace Lab10.Models
{
    public class ArticleViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public IFormFile FormFile { get; set; }
        public int CategoryId { get; set; }
    }
}
