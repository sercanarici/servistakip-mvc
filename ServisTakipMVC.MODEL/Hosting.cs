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
    public class Hosting : Base
    {

        public int MusteriId { get; set; }

        [StringLength(200)]
        public string Aciklama { get; set; }

        public int HostingTipId { get; set; } 


        [Required]
        public DateTime BaslangicTarihi { get; set; }

        [Required]
        public DateTime BitisTarihi { get; set; }

        [DefaultValue(0)]
        public decimal Fiyat { get; set; } 

        [StringLength(3)]
        public string ParaBirimi { get; set; } //TODO: para_birimi = models.CharField(max_length=2, choices=settings.PARA_BIRIMI)

        [DefaultValue(false)]
        public bool Odendi { get; set; }

        //nav prop
        [ForeignKey("MusteriId")]
        public virtual Musteri Musterisi { get; set; }

        [ForeignKey("HostingTipId")]
        public virtual HostingTip HostingTipi { get; set; }

    }
}
