using HeavenHome.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace HeavenHome.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public ProductCategory ProductCategory { get; set; }

        //relationships
        public List<Material_Product> Materials_Products { get; set; }

        //company
        public Company Company { get; set; }
    }
}
