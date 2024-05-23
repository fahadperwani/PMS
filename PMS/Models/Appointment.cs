using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS.Models
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public AppointmentStatus Status { get; set; }
    }

    public enum AppointmentStatus
    {
        Pending,
        Confirmed,
        Rescheduled,
        Cancelled
    }
}