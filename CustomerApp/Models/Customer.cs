using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }



        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
    }
}
