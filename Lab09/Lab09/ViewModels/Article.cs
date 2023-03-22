using System;
using System.ComponentModel.DataAnnotations;

namespace Lab09.ViewModels
{
    public enum Category { Food, Drinks }
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "To short name")]
        [MaxLength(30, ErrorMessage = " To long name, do not exceed {0}")] 
        public string Name { get; set; }
        public double Price { get; set; }
        [DataType(DataType.Date)]
        [Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        //[DisplayFormat(DataFormatString = "{0:yyy - MM - dd}")]
        public DateTime ExpirationDate { get; set; }
        public Category Category { get; set; }

        public Article()
        {

        }

        public Article(int id, string name, double price, DateTime expirationDate, Category category)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.ExpirationDate = expirationDate;
            this.Category = category;
        }
    }
}
