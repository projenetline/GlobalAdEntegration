using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netline.Pdks.JP.Entegration.Models
{
    public class VacationResult
    {
        public string PersonelCode { get; set; } = "";
        public string VacationType { get; set; } = "";
        public string VacationCode { get; set; } = "";
        public DateTime? BegDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string WageType { get; set; } = "";
        public string DurationType { get; set; } = "";
        public string Description { get; set; } = "";
        public string ModifierName { get; set; } = "";
        public double Duration { get; set; } = 0;

    }
}

