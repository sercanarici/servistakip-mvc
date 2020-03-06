using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakipMVC.MODEL
{
    public class CihazModel:Base
    {
        public int MarkaId { get; set; }

        [Required]
        [StringLength(255)]
        public string Model { get; set; }


        //NAV PROP
        [ForeignKey("MarkaId")]
        public virtual CihazMarka Markasi { get; set; }


    }
}
