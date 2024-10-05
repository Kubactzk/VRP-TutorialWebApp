using System.ComponentModel.DataAnnotations;

namespace VRP.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "X is Required")]
        public float X { get; set; }
        [Required(ErrorMessage = "Y is Required")]
        public float Y { get; set; }
    }
}
