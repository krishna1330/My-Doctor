using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Entities.DTOs
{
    public class HospitalsDto
    {
        public int HospitalId { get; set; }
        public string? HospitalName { get; set; }
        public string? Address { get; set; }
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string? DoctorName { get; set; }
        public string? Education { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public decimal Fee { get; set; }
    }
}
