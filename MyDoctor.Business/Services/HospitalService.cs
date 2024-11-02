using MyDoctor.Data;
using MyDoctor.Data.Repositories;
using MyDoctor.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Business.Services
{
    public class HospitalService
    {
        private readonly MyDoctorDbContext _dbcontext;
        private readonly HospitalsRepository _hospitalsRepository;

        public HospitalService(MyDoctorDbContext context, HospitalsRepository hospitalsRepository)
        {
            _dbcontext = context;
            _hospitalsRepository = hospitalsRepository;
        }

        public async Task<List<HospitalsDto>> GetHospitalsDtosAsync()
        {
            return await _hospitalsRepository.GetHospitalsDtosAsync();
        }
    }
}
