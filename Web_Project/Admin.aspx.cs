using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Project
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AutoUpdateGridView();
        }

        private void AutoUpdateGridView()
        {
            try 
            {
                using (var db = new CommunitySystemDataContext())
                {
                    var us = from uss in db.Members
                             select uss;
                    txtGridView.DataSource = us;
                    txtGridView.DataBind();
                };
            } catch (Exception ex) 
                {
                lblgridmsg.Text = ex.Message;    
                }
            
        }
    }
}