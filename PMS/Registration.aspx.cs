using Microsoft.Ajax.Utilities;
using PMS.DataLayer;
using PMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMS
{
    public partial class Registration : System.Web.UI.Page
    {
        private PMSContext _context = new PMSContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {

            // Get the values from the form
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            UserType userType = (UserType)Enum.Parse(typeof(UserType), UserType.SelectedValue);
            string specialization = txtSpecialization.Text;

            if (userType == Models.UserType.Doctor)
            {
                Doctor doctor = new Doctor
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    Specialization = specialization,
                    UserType = userType
                };

                _context.Doctors.Add(doctor);
                _context.SaveChanges();

            }
            else
            {
                Patient patient = new Patient
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    UserType = userType
                };

                _context.Patients.Add(patient);
                _context.SaveChanges();
            }


            Response.Redirect("Login.aspx");
        }
    }
}