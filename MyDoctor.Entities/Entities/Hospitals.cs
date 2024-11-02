using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("hospitals")]
    public class Hospitals
    {
        [Column("hospitalid")]
        public int HospitalId { get; set; }
        [Column("hospitalname")]
        public string? HospitalName { get; set; }
        [Column("address")]
        public string? Address { get; set; }
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
