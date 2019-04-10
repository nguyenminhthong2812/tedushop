﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        public string Description { set; get; }
        [Required]
        [MaxLength(500)]
        public string Image { set; get; }
        [Required]
        [MaxLength(500)]
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}
