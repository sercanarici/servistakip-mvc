using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServisTakipMVC.MODEL
{
    public class Cihaz : Base
    {

        //public int CihazMarkaId { get; set; }

        public int CihazModelId { get; set; }

        public int CihazTipId { get; set; }


        [Required]
        [StringLength(255)]
        public string SeriNo { get; set; }

        ////nav prop
        //[ForeignKey("CihazMarkaId")]
        //public virtual CihazMarka CihazMarkasi { get; set; }

        [ForeignKey("CihazModelId")]
        public virtual CihazModel CihazModeli { get; set; }

        [ForeignKey("CihazTipId")]
        public virtual CihazTip CihazTipi { get; set; }



    }
}
