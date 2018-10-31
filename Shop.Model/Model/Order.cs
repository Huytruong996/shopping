using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string CustomerName { set; get; }
        [Required]
        public string CustomerAddress { set; get; }
        [Required]
        public string CustomerEmail { set; get; }
        [Required]
        public string CustomerMobile { set; get; }
        public string CustomerMessage { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }
        [Required]
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
