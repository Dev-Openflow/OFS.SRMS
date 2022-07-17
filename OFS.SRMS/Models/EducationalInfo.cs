using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFS.SRMS.Models
{
    public class EducationalInfo
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public string ElemSchool { get; set; }
        public string ElemAddress { get; set; }
        public int ElemYear { get; set; }
        public string HighSchool { get; set; }
        public string HighSchoolAddress { get; set; }
        public int HighSchoolYear { get; set; }
    }
}
