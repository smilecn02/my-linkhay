using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLinkhay.Models
{
    public class HMSContext : DbContext
    {
        public HMSContext()
            : base("name=DefaultConnection")
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Linkhay> Linkhays { get; set; }

    }
}