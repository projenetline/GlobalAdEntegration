using Netline.Pdks.JP.BusinessLayer;
using Netline.Pdks.JP.Entegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Netline.Pdks.JP.Entegration.Controllers
{
    public class PersonelController : ApiController
    {
        /// <summary>
        /// Tc Kimlik  numarası ile Personel sorgulama metodudur.
        /// </summary>
        [HttpGet]
        [Authorize]
        [Route("api/Personel/getPersonelByTckNo")]
        public PersonelResult getPersonelByTckNo(string TckNo)
        {
            ProjectUtil util= new ProjectUtil();
            return util.getPersonelByTckNo(TckNo);
        }
        /// <summary>
        /// Değişiklik olan Personel listeleme metodudur.
        /// </summary>
        [HttpGet]
        [Authorize]
        [Route("api/Personel/getPersonels")]
        public List<PersonelResult> getPersonels()
        {
            ProjectUtil util= new ProjectUtil();
            return util.getPersonels();
        }

      

    }
}
