using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("customer")]
    public class Customer
    {
        // ACSC384 - To Do - Customer Class
        [Key]
        [Column("customerid")]
        public int CustomerId { get; set; }
        [Column("surname")]
        [StringLength(70)]
        public string Surname { get; set; } = string.Empty;
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Column("address")]
        [StringLength(250)]
        public string Address { get; set; } = string.Empty;
        [Column("telephone")]
        [StringLength(20)]
        public string Telephone { get; set; } = string.Empty;
        [Column("licence")]
        public int Licence { get; set; }
        // Navigation
        // Navigation
        public ICollection<CustReservation> CustReservations { get; set; } = new List<CustReservation>();
    }
}