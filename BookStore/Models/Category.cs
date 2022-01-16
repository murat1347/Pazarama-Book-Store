using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Category name not empty")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Book> Foods { get; set; }
        public bool Status { get; set; }
    }
}
