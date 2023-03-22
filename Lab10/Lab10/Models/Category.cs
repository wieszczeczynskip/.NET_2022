using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab10.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();

        public Category()
        {

        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category(string name)
        {
            Name = name;
        }
    }
}
