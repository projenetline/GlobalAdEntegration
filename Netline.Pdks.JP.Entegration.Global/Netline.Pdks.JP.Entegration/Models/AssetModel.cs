using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netline.Galataport.WS.Models
{
 

    public class AssetModel : RequiredAttribute
    {      

        /// <summary>
        /// Cari kodu
        /// </summary>
        [Required]
        public string ClCode { get; set; } = "";
        /// <summary>
        /// Sözleşme No
        /// </summary>
        [Required]
        public string ContractNo { get; set; } = "";

        /// <summary>
        /// Fatura Tarihi
        /// </summary>
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Özel Kod (Opsiyonel)
        /// </summary>
        public string SpeCode { get; set; } = "";

        /// <summary>
        /// Yetki Kodu (Opsiyonel)
        /// </summary>
        public string AuthCode { get; set; } = "";

        /// <summary>
        /// Döküman İzleme numarası (Opsiyonel) (32 Karakter)
        /// </summary>
        public string DocTrackingNr { get; set; } = "";

        /// <summary>
        /// Para Birimi
        /// </summary>
        [Required]
        public Currency CurrType { get; set; }

        /// <summary>
        /// Döviz Kuru (6.86)
        /// </summary>
        [Required]
        public double CurrRate { get; set; } = 0;

        /// <summary>
        /// Ticari İşlem Grubu (Opsiyonel)
        /// </summary>
        public string TradingGroup { get; set; } = "";


        /// <summary>
        /// Fatura Satırları
        /// </summary>
        public List<AssetLineModel> Lines { get; set; }

    }

    public class AssetLineModel
    {
        /// <summary>
        /// Satır Türü  ( 0 : Malzeme  - 4 : Hizmet  )
        /// </summary>       
        public int LineType { get; set; } = 0;

        /// <summary>
        /// Sabit Kıymet Kodu
        /// </summary>
        [Required]
        public string MasterCode { get; set; } = "";


        /// <summary>
        /// Sabit Kıymet Açıklaması
        /// </summary>
        [Required]
        public string MasterDef { get; set; } = "";


        /// <summary>
        /// Masraf Kodu (Opsiyonel)
        /// </summary>
        public string CenterCode { get; set; } = "";

        /// <summary>
        /// Satır Özel Kodu (Opsiyonel)
        /// </summary>
        public string SpeCode { get; set; } = "";

        /// <summary>
        /// Birim Fiyat
        /// </summary>
        [Required]
        public double Price { get; set; } = 0;

        /// <summary>
        /// Miktar
        /// </summary>
        [Required]
        public double Quantity { get; set; } = 0;
        /// <summary>
        /// İndirm tutarı için kullanılacak alandır.
        /// </summary>
        [Required]
        public double Total { get; set; } = 0;
        /// <summary>
        /// KDV oranı
        /// </summary>
        [Required]
        public double VatRate { get; set; } = 0;

        /// <summary>
        /// Satır Açıklaması 
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// Amortisman Oranı
        /// </summary>
        [Required]
        public double DeprRate { get; set; } = 0;


        

    }
}