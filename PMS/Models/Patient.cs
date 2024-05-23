using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Models
{
    public class Patient : User
    {
        public ICollection<Appointment> Appointments { get; set; }
    }
}