﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakipMVC.MODEL
{
    public class CihazMarka:Base
    {
        [Required]
        [StringLength(100)]
        public string Adi { get; set; }
    }
}
