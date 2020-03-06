using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServisTakipMVC.MODEL
{
    public class ServisForm:Base
    {
        public int MusteriId { get; set; } 

        [StringLength(10)]
        public string BelgeNo { get; set; }

        public int ServisTipId { get; set; }

        public int ServisIcerikId { get; set; }

        public int ServisSekliId { get; set; }

        [Required]
        public DateTime BaslangicTarihi { get; set; }

        [Required]
        public DateTime BitisTarihi { get; set; }

        public string YapilanIslemler { get; set; }

        public string Notlar { get; set; }


        public int KullaniciId { get; set; }  

        [StringLength(100)]
        public string MusteriAdi { get; set; }


        public int? BakimAnlasmaId { get; set; } 

        public decimal ServisUcreti { get; set; }

        [StringLength(3)]
        public string ParaBirimi { get; set; } //TODO: para_birimi = models.CharField(max_length=2, choices=settings.PARA_BIRIMI)

        [DefaultValue(false)]
        public bool Odendi { get; set; }

        //nav prop
        [ForeignKey("MusteriId")]
        public virtual Musteri Musterisi { get; set; }

        [ForeignKey("ServisTipId")]
        public virtual ServisTip ServisTipi { get; set; }

        [ForeignKey("ServisIcerikId")]
        public virtual ServisIcerik ServisIcerigi { get; set; }

        [ForeignKey("ServisSekliId")]
        public virtual ServisSekli ServisSekli { get; set; }

        [ForeignKey("KullaniciId")]
        public virtual Kullanici ServisSorumlusu { get; set; }

        [ForeignKey("BakimAnlasmaId")]
        public virtual BakimAnlasma BakimAnlasmasi { get; set; }

    }
}
