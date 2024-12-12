using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP1083amp.Models
{
    public class Urun
    {
        [Key]
        public int UrunKodu { get; set; }

        public string UrunAdi { get; set; }

        public int KategoriId { get; set; }

        public int TedarikciId { get; set; }

        public int StokAdedi { get; set; }

        public Decimal Fiyat { get; set; }

        public int Acıklama { get; set; }

        //bir kategorinin birden fazla ürünü olabilir   

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
