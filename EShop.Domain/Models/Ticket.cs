using System.ComponentModel.DataAnnotations;
using EShop.Domain.Identity;

namespace EShop.Domain.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double Price { get; set; }
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public virtual EShopApplicationUser? CreatedBy { get; set; }

    }
}
