using System.ComponentModel.DataAnnotations;

namespace HeavenHome.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Company logo")]
        public string Logo { get; set; }
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        [Display(Name = "Company Description")]
        public string Description { get; set; }

        //relationships
        public List<Product> Products { get; set; }
    }
}
