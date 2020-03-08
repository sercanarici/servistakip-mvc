using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServisTakipMVC.MODEL
{
    public class Kullanici:Base
    {
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Kullanici adı 5-20 karakter aralığında olmalıdır.")]
        public string KullaniciAdi { get; set; } 

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Ad 2-20 karakter aralığında olmalıdır.")]
        public string Ad { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Soyad 2-20 karakter aralığında olmalıdır.")]
        public string Soyad { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Parola { get; set; }

        public DateTime? SonGirisZamani { get; set; }
    }
}
