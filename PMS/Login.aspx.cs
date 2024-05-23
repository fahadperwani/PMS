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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private PMSContext _context = new PMSContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            UserType userType = (UserType)Enum.Parse(typeof(UserType), ddlUserType.SelectedValue);

            if (userType == UserType.Doctor)
            {
                Doctor doctor = _context.Doctors
                    .Where(d => d.Email == email && d.Password == password)
                    .FirstOrDefault();

                if (doctor != null)
                {
                    // Login successful, redirect to doctor dashboard
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    // Login failed, display error message
                    lblError.Text = "Invalid email or password";
                }
            }
            else
            {
                Patient patient = _context.Patients
                    .Where(p => p.Email == email && p.Password == password)
                    .FirstOrDefault();

                if (patient != null)
                {
                    // Login successful, redirect to patient dashboard
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    // Login failed, display error message
                    lblError.Text = "Invalid email or password";
                }
            }
        }
    }
}