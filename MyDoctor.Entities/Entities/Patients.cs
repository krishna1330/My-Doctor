using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("patients")]
    public class Patients
    {
        [Key]
        [Column("patientid")]
        public int PatientId { get; set; }
        [ForeignKey("users")]
        [Column("userid")]
        public int UserId { get; set; }
        [Column("patientname")]
        public string? PatientName { get; set; }
        [Column("patientdob")]
        public DateTime PatientDOB { get; set; }
        [ForeignKey("Statuses")]
        [Column("statusid")]
        public int StatusId { get; set; }
        [Column("createdate")]
        public DateTime CreatedDate { get; set; }
        [Column("createdby")]
        public int CreatedBy { get; set; }
        [Column("modifieddate")]
        public DateTime ModifiedDate { get; set; }
        [Column("modifiedby")]
        public int ModifiedBy {   get; set;   }
    }
}