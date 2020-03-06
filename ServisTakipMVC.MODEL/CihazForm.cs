using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ServisTakipMVC.MODEL
{
    public class CihazForm : Base
    {
        public int MusteriId { get; set; }

        [StringLength(10)]
        public string BelgeNo { get; set; } 

        public int TeslimAlanKullaniciId { get; set; }

        public int CihazId { get; set; }

        public DateTime TeslimAlmaTarihi { get; set; }

        public string Ariza { get; set; }

        public DateTime? TeslimEtmeTarihi { get; set; }

        public string YapılanIslemler { get; set; }

        public bool GarantiDahili { get; set; }

        [DefaultValue(0)]
        public decimal Fiyat { get; set; } 

        [StringLength(3)]
        public string ParaBirimi { get; set; } //TODO: para_birimi = models.CharField(max_length=2, choices=settings.PARA_BIRIMI)


        //nav prop
        [ForeignKey("MusteriId")]
        public virtual Musteri Musterisi { get; set; }

        [ForeignKey("TeslimAlanKullaniciId")]
        public virtual Kullanici TeslimAlan { get; set; }


    }
}
