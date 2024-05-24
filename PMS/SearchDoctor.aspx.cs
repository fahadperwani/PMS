using PMS.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMS
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            using (var dbContext = new PMSContext())
            {
                var doctors = dbContext.Doctors
                    .Where(d => d.Name.Contains(searchQuery))
                    .ToList();
                gvDoctors.DataSource = doctors;
                gvDoctors.DataBind();
            }
        }

        protected void btnBookAppointment_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int doctorId = int.Parse(btn.CommandArgument);
            Response.Redirect("BookAppointments.aspx?DoctorId=" + doctorId);
        }
    }
}