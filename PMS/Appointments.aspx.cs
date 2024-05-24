using PMS.DataLayer;
using PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMS
{
    public partial class Appointments : System.Web.UI.Page
    {
        PMSContext _context = new PMSContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            int userId;
            if (Session["doctor"] != null)
            {
                var doctor = (Doctor)Session["doctor"];
                userId = doctor.Id;

                var appointments = _context.Appointments
                    .Where(a => a.DoctorId == userId)
                    .Select(a => new
                    {
                        PatientName = _context.Patients.FirstOrDefault(p => p.Id == a.PatientId),
                        Date = a.Date,
                    })
                    .ToList();

                AppointmentsGridView.DataSource = appointments;
                AppointmentsGridView.DataBind();

            }
            else if (Session["patient"] != null)
            {
                var patient = (Patient)Session["patient"];
                userId = patient.Id;

                var appointments = _context.Appointments
                    .Where(a => a.PatientId == userId)
                    .Select(a => new
                    {
                        DoctorName = _context.Doctors.FirstOrDefault(d => d.Id == a.DoctorId),
                        Date = a.Date,
                    })
                    .ToList();

                AppointmentsGridView.DataSource = appointments;
                AppointmentsGridView.DataBind();


            }
        }

        protected void AppointmentsGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                if (Session["Patient"] != null)
                {
                    e.Row.Cells[0].Text = "Doctor Name";
                }
                else if (Session["Doctor"] != null)
                {
                    e.Row.Cells[0].Text = "Patient Name";
                }
            }
        }

    }
}