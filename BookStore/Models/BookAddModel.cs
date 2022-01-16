using Microsoft.AspNetCore.Http;

namespace BookStore.Models
{
    public class BookAddModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public IFormFile ImageUrl { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }
}
