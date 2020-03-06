﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakipMVC.MODEL
{
    public class CihazTip:Base
    {
        [Required]
        [StringLength(255)]
        public string Adi { get; set; }
    }
}
