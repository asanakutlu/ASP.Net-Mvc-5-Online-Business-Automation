﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string ProductInformation { get; set; }
    }
}