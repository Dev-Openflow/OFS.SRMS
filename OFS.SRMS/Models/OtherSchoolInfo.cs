using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFS.SRMS.Models
{
    public class OtherSchoolInfo
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public string OtherSchoolAttended { get; set; }
        public int YearAttended { get; set; }
    }
}
