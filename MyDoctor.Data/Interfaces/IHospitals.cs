using MyDoctor.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Data.Interfaces
{
    internal interface IHospitals
    {
        Task<List<HospitalsDto>> GetHospitalsDtosAsync();
    }
}