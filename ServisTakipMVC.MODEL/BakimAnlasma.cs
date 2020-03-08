using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakipMVC.MODEL
{
    public class BakimAnlasma:Base
    {
        [Required]
        public int MusteriId { get; set; } 

        [Required]
        public DateTime BaslangicTarihi { get; set; }

        [Required]
        public DateTime BitisTarihi { get; set; }

        public int BakimAnlasmaTipId { get; set; }

        public string Not { get; set; }

        public decimal AnlasilanFiyat { get; set; } 

        [StringLength(3)]
        public string ParaBirimi { get; set; } //TODO: para_birimi = models.CharField(max_length=2, choices=settings.PARA_BIRIMI)

        [DefaultValue(false)]
        public bool Odendi { get; set; }

        //nav prop
        [ForeignKey("MusteriId")]
        public virtual Musteri Musterisi { get; set; }

        [ForeignKey("BakimAnlasmaTipId")]
        public virtual BakimAnlasmaTip AnlasmaTipi { get; set; }

    }
}
