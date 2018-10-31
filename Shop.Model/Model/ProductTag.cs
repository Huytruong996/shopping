using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [Key]
        public int TagID { set; get; }

        [ForeignKey("ProductID")]
        public Product Product { set; get; }
        [ForeignKey("TagID")]
        public Tag Tag { set; get; }
    }
}
