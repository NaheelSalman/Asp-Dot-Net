using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Project
{
    public partial class SignUpForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddNewMember_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CommunitySystemDataContext())
                {
                    Members mb = new Members()
                    {
                        First_Name = txtFirstName.Text,
                        Last_Name = txtLastName.Text,
                        Email = txtEmail.Text,
                        Contact_No = txtContactNo.Text,
                        Date_Of_Birth = Convert.ToDateTime(txtDOB.Text),
                        Password = txtPassword.Text
                    };
                    db.Members.InsertOnSubmit(mb);
                    db.SubmitChanges();
                }
                lblMessage.Text = "You are a Member Now !";
            } 
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;

            }
        }
    }
}