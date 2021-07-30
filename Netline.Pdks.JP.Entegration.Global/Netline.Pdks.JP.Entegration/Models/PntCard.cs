using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netline.Pdks.JP.Entegration.Models
{
    public class PntCard
    {

        /// <summary>
        /// Sicil kodu
        /// </summary>
        [Required]
        public string PerCode { get; set; } = "";


        /// <summary>
        ///Puantaj Ayı
        /// </summary>       
        public int PntMonth { get; set; } =0;


        /// <summary>
        ///Puantaj Yılı
        /// </summary>       
        public int PntYear { get; set; } = 0;
        /// <summary>
        /// Sgk Gün
        /// </summary>       
        public double SgkGun { get; set; } = 0;

        /// <summary>
        /// Vergi Ödeme Günü
        /// </summary>       
        public double VergiOdemeGunu { get; set; } = 0;

        /// <summary>
        /// Toplam Çalışma Günü
        /// </summary>       
        public double ToplamCalismaGunu { get; set; } = 0;


        /// <summary>
        /// Normal Çalışma Günü
        /// </summary>       
        public double Gun { get; set; } = 0;

        /// <summary>
        /// Normal Çalışma Günü
        /// </summary>       
        public double Saat { get; set; } = 0;

        /// <summary>
        /// Hafta Tatili Günü
        /// </summary>       
        public double HTatGun { get; set; } = 0;

        /// <summary>
        /// Hafta Tatili Saat
        /// </summary>       
        public double HTatSaat { get; set; } = 0;

        /// <summary>
        /// Resmi Tatil (Genel Tatil) Günü
        /// </summary>       
        public double GTatGun { get; set; } = 0;

        /// <summary>
        /// Resmi Tatil (Genel Tatil) Saat
        /// </summary>       
        public double GTatSaat { get; set; } = 0;

       
        /// <summary>
        /// Yıllık İzin Günü
        /// </summary>       
        public double YillikIzinGun { get; set; } = 0;

        /// <summary>
        /// Yıllık İzin Saati
        /// </summary>   
        public double YillikIzinSaat { get; set; } = 0;


        /// <summary>
        /// Sosyal İzin Gün
        /// </summary>       
        public double SosyalIzinGun { get; set; } = 0;

        /// <summary>
        /// Sosyal İzin  Saati
        /// </summary>   
        public double SosyalIzinSaat { get; set; } = 0;

        /// <summary>
        /// İdari İzin Gün
        /// </summary>       
        public double IdariGun { get; set; } = 0;

        /// <summary>
        /// İdari İzin  Saati
        /// </summary>   
        public double IdariSaat { get; set; } = 0;


        /// <summary>
        /// Ucretsiz Izin Gun
        /// </summary>  
        public double UsizIzinGun { get; set; } = 0;

        /// <summary>
        /// Ucretsiz Izin Saati
        /// </summary>  
        public double UsizIzinSaat { get; set; } = 0;


        /// <summary>
        /// İstarahat Gün
        /// </summary>  
        public double IstrahatGun { get; set; } = 0;

        /// <summary>
        /// İstarahat Saat
        /// </summary>  
        public double IstrahatSaat { get; set; } = 0;

        /// <summary>
        /// Kisa Calisma Odenegi Gun
        /// </summary>  
        public double KisaCalismaOdenegiGun { get; set; } = 0;

        /// <summary>
        /// Kisa Calisma Odenegi Saat
        /// </summary>  
        public double KisaCalismaOdenegisaat { get; set; } = 0;

        /// <summary>
        ///  Nakdi Gün
        /// </summary>       
        public double PandemiUsizGun { get; set; } = 0;

        /// <summary>
        ///  Nakdi Saat
        /// </summary>       
        public double PandemiUsizSaat { get; set; } = 0;


        /// <summary>
        /// Fazla Mesai 1
        /// </summary>       
        public double Fzm1 { get; set; } = 0;

        /// <summary>
        /// Fazla Mesai 2
        /// </summary>       
        public double BayramMesaisi { get; set; } = 0;

    

    }
}