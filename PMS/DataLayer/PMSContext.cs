using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PMS.Models;

namespace PMS.DataLayer
{
    public class PMSContext: DbContext
    {
        public PMSContext() : base("PMSDB")
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}