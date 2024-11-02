using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.Entities
{
    [Table("appointments")]
    public class Appointments
    {
        [Column("appointmentid")]
        public int AppointmentId { get; set; }
        [ForeignKey("patients")]
        [Column("patientid")]
        public int PatientId { get; set; }
        [ForeignKey("doctors")]
        [Column("doctorid")]
        public int DoctorId { get; set; }
        [Column("token")]
        public int Token { get; set; }
        [Column("diagnosis")]
        public string? Diagnosis { get; set; }
        [Column("medicine")]
        public string? Medicine { get; set; }
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
