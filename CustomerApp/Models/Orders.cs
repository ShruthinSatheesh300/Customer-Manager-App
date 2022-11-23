using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Models
{


    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? ItemName { get; set; }

        [Required]
        public double Price { get; set; }



        
        public int CustomerId { get; set; }

    }
}
