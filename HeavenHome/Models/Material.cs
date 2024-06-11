using System.ComponentModel.DataAnnotations;

namespace HeavenHome.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //relationships
        public List<Material_Product> Materials_Products { get; set; }

    }
}
