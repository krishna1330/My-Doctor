using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("doctors")]
    public class Doctors
    {
        [Column("doctorid")]
        public int DoctorId { get; set; }
        [ForeignKey("users")]
        [Column("userid")]
        public int UserId { get; set; }
        [ForeignKey("hospitals")]
        [Column("hospitalid")]
        public int HospitalId { get; set; }
        [Column("education")]
        public string? Education { get; set; }
        [Column("availablefrom")]
        public DateTime AvailableFrom { get; set; }
        [Column("availableto")]
        public DateTime AvailableTo { get; set; }
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
        public int ModifiedBy { get; set; }
    }
}
