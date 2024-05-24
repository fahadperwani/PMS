using PMS.DataLayer;
using PMS.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMS
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int doctorId = int.Parse(Request.QueryString["DoctorId"]);
                using (var dbContext = new PMSContext())
                {
                    var doctor = dbContext.Doctors.Find(doctorId);
                    lblDoctorName.Text = "Book an appointment with Dr. " + doctor.Name;

                    var appointments = dbContext.Appointments
                        .Where(a => a.DoctorId == doctorId)
                        .ToList();

                    var availableTimes = GetAvailableTimes(appointments);
                    foreach (var time in availableTimes)
                    {
                        ddlAvailableTimes.Items.Add(new ListItem(time.ToString("HH:mm") + " - " + time.AddHours(1).ToString("HH:mm")));
                    }
                }
            }
        }

        protected void btnBookAppointment_Click(object sender, EventArgs e)
        {
            if (Session["patient"] != null)
            {
                var patient = (Patient)Session["patient"];
                int doctorId = int.Parse(Request.QueryString["DoctorId"]);
                String time = ddlAvailableTimes.SelectedValue.Split('-')[0].Trim();
                DateTime appointmentTime = DateTime.ParseExact(time, "HH:mm", null);
                Console.WriteLine(time);
                //DateTime appointmentTime = DateTime.Parse(ddlAvailableTimes.SelectedValue);
                using (var dbContext = new PMSContext())
                {
                    var appointment = new Appointment
                    {
                        PatientId = patient.Id,
                        DoctorId = doctorId,
                        Date = appointmentTime,
                        Description = "",
                        Status = AppointmentStatus.Pending
                    };
                    dbContext.Appointments.Add(appointment);
                    dbContext.SaveChanges();
                    Response.Redirect("SearchDoctor.aspx");
                }
            }
        }

        private List<DateTime> GetAvailableTimes(List<Appointment> appointments)
        {
            var availableTimes = new List<DateTime>();
            for (int i = 9; i < 17; i++)
            {
                DateTime time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, i, 0, 0);
                if (!appointments.Any(a => a.Date == time))
                {
                    availableTimes.Add(time);
                }
            }
            return availableTimes;
        }
    }
}