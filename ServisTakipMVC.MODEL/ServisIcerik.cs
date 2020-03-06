using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServisTakipMVC.MODEL
{
    public class ServisIcerik:Base
    {
        [Required]
        [StringLength(50)]
        public string Adi { get; set; }
    }
}
