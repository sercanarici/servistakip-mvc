using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisTakipMVC.MODEL
{
    public class BakimAnlasmaTip : Base
    {
        [Required]
        [StringLength(100)]
        public string Adi { get; set; }

        public bool Devir { get; set; }

        public bool UzakBaglanti { get; set; }

        public bool TelefonDestek { get; set; }

        public bool YerindeServis { get; set; }

        public bool Install { get; set; }

        public bool VersiyonGecis { get; set; }

        public bool EgitimDestek { get; set; }

        public bool BulutYedekleme { get; set; }

        public bool RaporDestek { get; set; }


        public decimal Fiyat { get; set; }

        [StringLength(3)]
        public string ParaBirimi { get; set; } //TODO: para_birimi = models.CharField(max_length=2, choices=settings.PARA_BIRIMI)

    }
}
