using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFS.SRMS.Models
{
    public class FamilyInfo
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public string FatherName { get; set; }
        public long FatherContact { get; set; }
        public string FatherAddress { get; set; }
        public string MotherName { get; set; }
        public long MotherContact { get; set; }
        public string MotherAddress { get; set; }
        public string Guardian { get; set; }
        public long GuardianContact { get; set; }
        public string GuardianAddress { get; set; }
        public string RelationshiptoGuardian { get; set; }
        public string Spouse { get; set; }
        public long SpouseContact { get; set; }
    }
}
