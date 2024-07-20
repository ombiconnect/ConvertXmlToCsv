using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertXmlToCsv
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StudyAuditData")]
    public class StudyAuditData
    {
        [Key]        public int Id { get; set; } // Identity column as primary key

        public string StudyOID { get; set; }
        public string SubjectKey { get; set; }
        public string SubjectKeyType { get; set; }
        public string SubjectName { get; set; }
        public int? LocationOID { get; set; }
        public int? StudyEnvSiteNumber { get; set; }
        public string StudyEventOID { get; set; }
        public string FormOID { get; set; }
        public int? FormRepeatKey { get; set; }
        public string ItemGroupOID { get; set; }
        public string ItemOID { get; set; }
        public string TransactionType { get; set; }
        public string Value { get; set; }
    }

}
