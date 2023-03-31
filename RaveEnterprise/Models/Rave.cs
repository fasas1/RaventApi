using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaveEnterprise.Models
{
    public class Rave
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public long Price { get; set; }
        public string? PictureUrl { get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
