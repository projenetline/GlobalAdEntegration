using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Configuration;
using System.Web;

namespace Netline.Galataport.WS.Models
{
    public class InvoiceModel
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
        /// Fatura Türü  ( 7 : Perakende  - 8 : Toptan  )
        /// </summary>
        [Required]
        public int Type { get; set; } = 0;

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
        /// Fatura Açıklaması (300 karakter)
        /// </summary>
        public string Notes { get; set; } = "";
        /// <summary>
        /// Fatura Satırları
        /// </summary>
        public List<InvoiceLineModel> Lines { get; set; }

    }

    public class InvoiceLineModel
    {
        /// <summary>
        /// Satır Türü  ( 0 : Malzeme  - 4 : Hizmet  )
        /// </summary>       
        public int LineType { get; set; } = 0;

        /// <summary>
        /// Ürün / Hizmet Kodu
        /// </summary>
      
        public string MasterCode { get; set; } = "";


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
      
        public double Price { get; set; } = 0;

        /// <summary>
        /// Miktar
        /// </summary>
       
        public double Quantity { get; set; } = 0;
        /// <summary>
        /// İndirm tutarı için kullanılacak alandır.
        /// </summary>
      
        public double Total { get; set; } = 0;
        /// <summary>
        /// KDV oranı
        /// </summary>
      
        public double VatRate { get; set; } = 0;

        /// <summary>
        /// Satır Açıklaması 
        /// </summary>
        public string Description { get; set; } = "";

    }

    public enum  Currency
    {
        USD=1,
        EUR=20,
        GBP=17,
        DEM=2,
        AUD=3,
        ATS=4,
        BEF=5,
        DKK=6,
        FIM=7,
        FRF=8,
        NLG=9,
        SEK=10,
        CHF=11,
        ITL=12,
        JPY=13,
        CAD=14,
        KWD=15,
        NOK=16,
        SAR=18,
        XEU=19,
        AZM=21,
        BRL=22,
        BGN=23,
        CZK=24,
        CNY=25,
        EEK=26,
        GEL=27,
        INR=28,
        HKD=29,
        IQD=30,
        IRR=31,
        IEP=32,
        ESP=33,
        ILS=34,
        ISK=35,
        CYP=36,
        KGS=37,
        LVL=38,
        LYD=39,
        LBP=40,
        LTL=41,
        LUF=42,
        HUF=43,
        MYR=44,
        MXN=45,
        EGP=46,
        BBD=47,
        PLN=48,
        PTE=49,
        ROL=50,
        RUR=51,
        TWD=52,
        TRY=53,
        JOD=54,
        GRD=55,
        ARS=56,
        LAK=57,
        AOA=58,
        AED=59,
        AFN=60,
        ALL=61,
        ANG=62,
        ADP=63,
        BDT=64,
        BHD=65,
        BIF=66,
        BMD=67,
        BND=68,
        BOB=69,
        BSD=70,
        BTN=71,
        BWP=72,
        BZD=73,
        CLP=74,
        COP=75,
        CRC=76,
        CUP=77,
        CVE=78,
        DJF=79,
        DOP=80,
        DZD=81,
        ECS=82,
        ETB=83,
        FJD=84,
        FKP=85,
        GHS=86,
        GIP=87,
        GMD=88,
        GNF=89,
        GTQ=90,
        GWP=91,
        GYD=92,
        HNL=93,
        HTG=94,
        IDR=95,
        JMD=96,
        KES=97,
        KHR=98,
        KMF=99,
        KPW=100,
        KRW=101,
        KYD=102,
        LKR=103,
        LRD=104,
        LSL=105,
        MAD=106,
        MNT=107,
        MOP=108,
        MRO=109,
        MTL=110,
        MUR=111,
        MVR=112,
        MWK=113,
        MZN=114,
        NGN=115,
        NIO=116,
        NPR=117,
        NZD=118,
        OMR=119,
        PAB=120,
        PEN=121,
        PGK=122,
        PHP=123,
        PKR=124,
        PYG=125,
        QAR=126,
        RWF=127,
        SBD=128,
        SCR=129,
        SDG=130,
        SGD=131,
        SHP=132,
        SLL=133,
        SOS=134,
        SRD=135,
        STD=136,
        SVC=137,
        SYP=138,
        SZL=139,
        THB=140,
        TND=141,
        TPE=142,
        TTD=143,
        TZS=144,
        UGX=145,
        UYU=146,
        VEB=147,
        VND=148,
        WST=149,
        YDD=150,
        YER=151,
        YUD=152,
        ZAR=153,
        ZMK=154,
        ZWL=155,
        KZT=156,
        UAH=157,
        TMT=158,
        UZS=159,
        TL=160,
        RON=161,
        AZN=162,
        AMD=164,
        AWG=165,
        BAM=166,
        BYR=167,
        CDF=168,
        ERN=169,
        HRK=170,
        MDL=171,
        MGA=172,
        MKD=173,
        MMK=174,
        NAD=175,
        RSD=176,
        TJS=177,
        TOP=178,
        VEF=179,
        VUV=180,
        XAF=181,
        XCD=182,
        XOF=183,
        XPF=184



    }
}