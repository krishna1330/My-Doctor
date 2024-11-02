using Microsoft.EntityFrameworkCore;
using MyDoctor.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Data
{
    public class MyDoctorDbContext : DbContext
    {
        public MyDoctorDbContext(DbContextOptions<MyDoctorDbContext> options) : base(options)
        {
        }

        public DbSet<UserTypes> UserTypes {  get; set; }

        public DbSet<Statuses> Statuses { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Hospitals> Hospitals { get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Patients> Patients { get; set; }

        public DbSet<Appointments> Appointments { get; set; }
    }
}
