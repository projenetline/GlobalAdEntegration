using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netline.Pdks.JP.Entegration.Models
{
    public class PersonelResult
    {
        public string SicilNo { get; set; } = "";
        public string Adi { get; set; } = "";
        public string Soyadi { get; set; } = "";
        public string AmirSicilNo { get; set; } = "";
        public string Departman { get; set; } = "";
        public string UstYonetici { get; set; } = "";
        public string Cinsiyet { get; set; } = "";
        public string Pozisyon { get; set; } = "";
        public string Birim { get; set; } = "";
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? GrubaGirisTarihi { get; set; }
        public int ÇalışılanYıl { get; set; } = 0;
        public string Tckno { get; set; } = "";
        public string Eposta { get; set; } = "";
        public string Gsm { get; set; } = "";
        public string Telefon { get; set; } = "";
    }
}

