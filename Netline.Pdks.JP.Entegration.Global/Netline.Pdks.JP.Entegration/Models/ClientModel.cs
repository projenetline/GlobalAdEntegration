using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netline.Galataport.WS.Models
{
    public class ClientModel
    {  /// <summary>
       /// Cari kartına ait Id referansı 
       /// </summary>      
        public int Logicalref { get; set; } = 0;
        /// <summary>
        /// Kart Tipi  3 Normal(Sözleşme)  , 4 Grup (Firma)
        /// </summary>
        [Required]
        public int CardType { get; set; } = 0;
        /// <summary>
        /// Grup firmaya ait Cari code 
        /// </summary>     
        public string ParentClCode { get; set; } = "";
        /// <summary>
        /// Cari Kod (Boş ise sıradan yeni kod oluşturulacak)
        /// </summary>      
        public string Code { get; set; } = "";
        /// <summary>
        /// Cari Unvanı
        /// </summary>
        [Required]
        public string Title { get; set; } = "";
        /// <summary>
        /// Vergi Numarası
        /// </summary>     
        public string TaxNr { get; set; } = "";

        /// <summary>
        /// Vergi Numarası
        /// </summary>     
        public string TckNo { get; set; } = "";



        /// <summary>
        /// Telefon No 1
        /// </summary>     
        public string TelNrs1 { get; set; } = "";

        /// <summary>
        /// Telefon No 2
        /// </summary>     
        public string TelNrs2 { get; set; } = "";


        /// <summary>
        /// Vergi dairesi
        /// </summary>   
        public string TaxOffice { get; set; } = "";
        /// <summary>
        /// Özel kod
        /// </summary>     
        public string SpeCode { get; set; } = "";
        /// <summary>
        /// Yetki Kodu
        /// </summary>       
        public string AuthCode { get; set; } = "";
        /// <summary>
        /// Adres 1 200 Karakter
        /// </summary> 
        public string Address1 { get; set; } = "";
        /// <summary>
        /// Adres 2 200 Karakter
        /// </summary>      
        public string Address2 { get; set; } = "";
        /// <summary>
        /// Semt (Örnek : Gayrettep)
        /// </summary>       
        public string District { get; set; } = "";
        /// <summary>
        /// İlçe (Örnek : Beşiktaş)
        /// </summary>        
        public string Town { get; set; } = "";
        /// <summary>
        /// Şehir
        /// </summary>
        [Required]
        public string City { get; set; } = "";
        /// <summary>
        /// Şehir Kodu
        /// </summary>
        [Required]
        public string CityCode { get; set; } = "";
        /// <summary>
        /// Ülke 
        /// </summary>
        [Required]
        public string Country { get; set; } = "";
        /// <summary>
        /// Ülke Kodu (TR)
        /// </summary>
        [Required]
        public string CountryCode { get; set; } = "";
        /// <summary>
        /// Cari Yetkili kişisi 
        /// </summary>       
        public string Contact { get; set; } = "";
        /// <summary>
        /// E-Posta Adresi
        /// </summary>      
        public string Email { get; set; } = "";
        /// <summary>
        /// 2. E-Posta Adresi
        /// </summary>       
        public string Email2 { get; set; } = "";
        /// <summary>
        /// Kullanımda / Kullanım Dışı 
        /// </summary>      
        public bool Active { get; set; } = false;
        /// <summary>
        /// Yabancı Şirket mi?
        /// </summary>
        public bool IsForeign { get; set; } = false;
        /// <summary>
        /// Kiracı Mı?
        /// </summary>
        public bool IsRenter { get; set; } = false;
        /// <summary>
        /// Şahıs şirketi mi?
        /// </summary>
        public bool IsPersCompany { get; set; } = false;

    }


    public class ClientResult
    {
        public ClientModel Client { get; set; } = new ClientModel();
        public string Result { get; set; } = "";

        public bool Success { get; set; } = false;
    }
}