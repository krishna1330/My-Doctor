using Microsoft.EntityFrameworkCore;
using MyDoctor.Data.Interfaces;
using MyDoctor.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Data.Repositories
{
    public class HospitalsRepository : IHospitals
    {
        private readonly MyDoctorDbContext _dbcontext;

        public HospitalsRepository(MyDoctorDbContext context) 
        {
            _dbcontext = context;
        }

        public async Task<List<HospitalsDto>> GetHospitalsDtosAsync()
        {
            try
            {
                var hospitalsDtos = await (from hospital in _dbcontext.Hospitals
                                           join doctor in _dbcontext.Doctors on hospital.HospitalId equals doctor.HospitalId
                                           join user in _dbcontext.Users on doctor.UserId equals user.UserId
                                           select new HospitalsDto
                                           {
                                               HospitalId = hospital.HospitalId,
                                               HospitalName = hospital.HospitalName,
                                               Address = hospital.Address,
                                               DoctorId = doctor.DoctorId,
                                               UserId = doctor.UserId,
                                               DoctorName = user.FirstName + " " + user.LastName,
                                               Education = doctor.Education,
                                               AvailableFrom = doctor.AvailableFrom,
                                               AvailableTo = doctor.AvailableTo,
                                               Fee = doctor.Fee
                                           }).ToListAsync();

                return hospitalsDtos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
