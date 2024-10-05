using System.ComponentModel.DataAnnotations;

namespace VRP.Models
{
    public class Depot
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public float X { get; set; }
        [Required]
        public float Y { get; set; }
    }
}
