using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netline.Galataport.WS.Models
{
    public class ContractModel
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
        /// Abonelikler
        /// </summary>
        [Required]
        public List<MemberModel> MemberList { get; set; } = new List<MemberModel>();

        /// <summary>
        /// Sözleşme Açıklaması
        /// </summary>
        [Required]
        public string Description { get; set; } = "";


        /// <summary>
        /// Sözleşme Başlangıç Tarihi
        /// </summary>
        [Required]
        public DateTime  BegDate { get; set; } = DateTime.Now;


        /// <summary>
        /// Sözleşme Bitiş Tarihi
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Signum tarafında oluşan Id ( RecordId ile güncelleme yapılır.)
        /// </summary>
        [Required]
        public string RecordId { get; set; } = "";


    }

    public class MemberModel
    {
        /// <summary>
        /// Abonelik Türü
        /// </summary>
        public string MemberType { get; set; } = "";
        /// <summary>
        ///Abone No
        /// </summary>
        public string MemberNo { get; set; } = "";
    }
}