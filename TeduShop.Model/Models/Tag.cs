﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]       
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID { set; get; }
        [MaxLength(250)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Type { set; get; }

        public virtual IEnumerable<PostTag> PostTag { set; get; }
    }
}
