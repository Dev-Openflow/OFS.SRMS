using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFS.SRMS.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public string Contact { get; set; }
        public string ContactType { get; set; }
        public string Type { get; set; }
        public bool isActive { get; set; }
    }
}
