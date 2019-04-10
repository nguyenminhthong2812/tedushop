using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(500)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(250)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(250)]
        public string CustomerMobile { set; get; }        
        public string CustomerMessage { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        [MaxLength(500)]
        public string PaymentMethod { set; get; }
        [Required]
        [MaxLength(500)]
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}
