using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        [MaxLength(500)]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}
