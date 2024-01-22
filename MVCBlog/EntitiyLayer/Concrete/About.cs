﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(500)]
        public string AboutConcat1 { get; set;}
        [StringLength(500)]
        public string AboutConcat2 { get; set;}
        [StringLength(100)]
        public string AboutImage1 { get; set;}
        [StringLength(100)]
        public string AboutImage2 { get; set;}

    }
}
