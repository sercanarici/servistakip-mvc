using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakipMVC.MODEL
{
    public class Musteri : Base
    {

        [Required]        
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Adres 2-255 karakter aralığında olmalıdır.")] 
        public string FirmaAdi { get; set; }

        [StringLength(100)]
        public string Telefon { get; set; }

        [StringLength(100)]
        public string Telefon2 { get; set; }

        [StringLength(50)]
        public string GsmNo { get; set; }

        [StringLength(50)]
        public string Faks { get; set; }

        [StringLength(100)]
        public string Yetkili { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }
        public string Adres { get; set; }
        public string Notlar { get; set; }

        [Required]
        public int BayiId { get; set; }


        //nav prop
        [ForeignKey("BayiId")]
        public virtual Bayi Bayisi { get; set; }

    }
}
