using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }
        [Required]
        public string Url { set; get; }
        public int? OrderDisplay { set; get; }
        [Required]
        public bool Status { set; get; }
    }
}
